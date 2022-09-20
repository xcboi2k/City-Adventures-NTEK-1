using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentScript : MonoBehaviour
{
    private NavMeshAgent m_Agent;
	public NavMeshAgent agent
	{
		get
		{
			if(!m_Agent)
				m_Agent = GetComponent<NavMeshAgent>();
			return m_Agent;
		}
	}

    [Header("Agent")]
	public TrafficType type = TrafficType.Pedestrian;
	public int maxSpeed = 20;

    public void Initialize()
	{
		agent.enabled = true;
		speed = TrafficSystemScript.Instance.GetAgentSpeedFromKPH(maxSpeed);
		agent.speed = speed;
		m_Destination = TrafficSystemScript.Instance.GetPedestrianDestination();
		if(m_Destination)
			agent.destination = m_Destination.position;
	}

    float m_Speed;
	public float speed
	{
		get { return m_Speed; }
		set { m_Speed = value; }
	}
	Transform m_Destination;

	public bool isWalking = false;
	public virtual void Update()
	{
		if(agent.isOnNavMesh)
		{
			if(CheckStop())
				agent.velocity = Vector3.zero;
				isWalking = false;
			CheckWaitZone();
			if(type == TrafficType.Pedestrian)
				TestDestination();
		}
	}

	private void TestDestination()
	{
		if(m_Destination)
		{
			float distanceToDestination = Vector3.Distance(transform.position, m_Destination.position);
			isWalking = true;
			if(distanceToDestination < 1f)
			{
				isWalking = false;
				m_Destination = TrafficSystemScript.Instance.GetPedestrianDestination();
				agent.destination = m_Destination.position;
			}
		}
	}

    public virtual void OnTriggerEnter(Collider col)
	{
		if(col.tag == "WaitZone")
		{
			WaitZoneScript waitZone = col.GetComponent<WaitZoneScript>();
			if(waitZone.type == type)
			{
				if(type == TrafficType.Pedestrian)
				{
					isWalking = false;
					if(CheckOppositeWAitZone(waitZone))
						return;
				}
				m_CurrentWaitZone = waitZone;
				if(!waitZone.canPass)
					m_IsWaiting = true;
			}
		}
	}

	private bool CheckOppositeWAitZone(WaitZoneScript waitZone)
	{
		if(waitZone.opposite)
		{
			if(waitZone.opposite == m_CurrentWaitZone)
				return true;
		}
		return false;
	}

    WaitZoneScript m_CurrentWaitZone;

	private bool m_IsWaiting;
	public bool isWaiting { get { return m_IsWaiting; }}

	private void CheckWaitZone()
	{
		if(m_IsWaiting)
		{
			if(m_CurrentWaitZone)
				m_IsWaiting = !m_CurrentWaitZone.canPass;
		}
	}

	public virtual bool CheckStop()
	{
		if(isWaiting)
			return true;
		return false;
	}
}
