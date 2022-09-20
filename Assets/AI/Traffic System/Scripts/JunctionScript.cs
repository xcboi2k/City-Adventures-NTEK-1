using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunctionScript : RoadScript
{
    public enum PhaseType { Timed, OnDemand }

    [Header("Junction")]
	public PhaseType type = PhaseType.Timed;
	public Phase[] phases;
	public JunctionTriggerScript[] triggers;
	public float phaseInterval = 5;

    public override void Start()
	{
		base.Start();
		if(phases.Length > 0)
			phases[0].Enable();
		foreach(JunctionTriggerScript jt in triggers)
			jt.junction = this;
	}

    private void Update()
	{
		if(type == PhaseType.Timed)
		{
			m_PhaseTimer += Time.deltaTime;
			if(!m_PhaseEnded && m_PhaseTimer > (phaseInterval * 0.5f))
				EndPhase();
			if(m_PhaseTimer > phaseInterval)
				ChangePhase();
		}
	}

    float m_PhaseTimer;
	bool m_PhaseEnded;
	private int m_CurrentPhase;

	private void EndPhase()
	{
		m_PhaseEnded = true;
		phases[m_CurrentPhase].End();
	}

	public void ChangePhase()
	{
		m_PhaseTimer = 0;
		m_PhaseEnded = false;
		if(m_CurrentPhase < phases.Length - 1)
			m_CurrentPhase++;
		else
			m_CurrentPhase = 0;
		phases[m_CurrentPhase].Enable();
	}

    [Serializable]
	public class Phase
	{
		public WaitZoneScript[] positiveZones;
		public WaitZoneScript[] negativeZones;
		public TrafficLightScript[] positiveLights;
		public TrafficLightScript[] negativeLights;
		public GameObject[] positiveCrossings;
		public GameObject[] negativeCrossings;

		public void Enable()
		{
			foreach(WaitZoneScript zone in positiveZones)
				zone.canPass = true;
			foreach(TrafficLightScript light in positiveLights)
				light.SetLight(true);
			foreach(WaitZoneScript zone in negativeZones)
				zone.canPass = false;
			foreach(TrafficLightScript light in negativeLights)
				light.SetLight(false);
			
			foreach(GameObject crossings in positiveCrossings){
				crossings.SetActive(true);
			}
			foreach(GameObject crossings in negativeCrossings){
				crossings.SetActive(false);
			}
		}

		public void End()
		{
			foreach(WaitZoneScript zone in positiveZones)
				zone.canPass = false;
		}
	}
}
