using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TrafficType { Pedestrian, Vehicle }
public class TrafficSystemScript : MonoBehaviour
{
    // Start is called before the first frame update
    private static TrafficSystemScript _Instance;
	public static TrafficSystemScript Instance
	{
		get
		{
			if(_Instance == null)
				_Instance = FindObjectOfType<TrafficSystemScript>();
			return _Instance;
		}
	}

    public bool drawGizmos = false;
	public GameObject pedestrianPrefab;	
	public GameObject[] vehiclePrefab; 
	public Transform pool;	
	public bool spawnOnStart = true;
	public int maxRoadVehicles = 100;
	public int maxPedestrians = 100;

    private List<RoadScript> m_Roads = new List<RoadScript>();

	private void Start () 
	{
		RoadScript[] roadsFound = FindObjectsOfType<RoadScript>();
		foreach(RoadScript r in roadsFound)
			m_Roads.Add(r);

		if(spawnOnStart)
		{
			for(int i = 0; i < maxRoadVehicles; i++)
				SpawnRoadVehicle(true);
			for(int i = 0; i < maxPedestrians; i++)
				SpawnPedestrian(true);
		}
	}

    private void Update()
	{
		if(Input.GetKeyUp(KeyCode.Backspace))
			SpawnPedestrian(true);
		if(Input.GetKeyUp(KeyCode.Return))
			SpawnRoadVehicle(true);
	}

    private int m_RoadVehicleSpawnAttempts;
	private int m_PedestrianSpawnAttempts;

    private void SpawnRoadVehicle(bool reset)
	{
		if(reset)
			m_RoadVehicleSpawnAttempts = 0;
		int index = UnityEngine.Random.Range(0, m_Roads.Count);
		RoadScript road = m_Roads[index];
		VehicleSpawn spawn;
		if(!road.TryGetVehicleSpawn(out spawn))
		{
			m_RoadVehicleSpawnAttempts++;
			if(m_RoadVehicleSpawnAttempts < m_Roads.Count)
				SpawnRoadVehicle(false);
			return;
		}

		int random = Random.Range(0, vehiclePrefab.Length);
		VehicleAIScript newVehicle = Instantiate(vehiclePrefab[random], spawn.spawn.position, spawn.spawn.rotation, pool.transform).GetComponent<VehicleAIScript>();
		newVehicle.Initialize(road, spawn.destination);
	}

    private void SpawnPedestrian(bool reset)
	{
		if(reset)
			m_PedestrianSpawnAttempts = 0;
		int index = UnityEngine.Random.Range(0, m_Roads.Count);
		RoadScript road = m_Roads[index];
		Transform spawn;
		if(!road.TryGetPedestrianSpawn(out spawn))
		{
			m_PedestrianSpawnAttempts++;
			if(m_PedestrianSpawnAttempts < m_Roads.Count)
				SpawnPedestrian(false);
			return;
		}
		AgentScript newAgent = Instantiate(pedestrianPrefab, spawn.position, spawn.rotation, pool.transform).GetComponent<AgentScript>();
		newAgent.Initialize();
	}

    public Transform GetPedestrianDestination()
	{
		int index = UnityEngine.Random.Range(0, m_Roads.Count);
		RoadScript road = m_Roads[index];
		Transform destination;
		if(!road.TryGetPedestrianSpawn(out destination))
		{
			return GetPedestrianDestination();
		}
		return destination;
	}

    public float GetAgentSpeedFromKPH(int kph)
	{
		return kph * .02f;
	}
}
