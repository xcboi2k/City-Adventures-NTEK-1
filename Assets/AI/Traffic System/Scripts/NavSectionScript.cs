using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavSectionScript : MonoBehaviour
{
    [Header("Nav Section")]
	public VehicleSpawn[] vehicleSpawns;
	public NavConnectionScript[] connections;
	public int speedLimit = 20;

	private int spawnRepeat = 2;

    public virtual void Start()
	{
		foreach(NavConnectionScript connection in connections)
			connection.navSection = this;
	}

    public bool TryGetVehicleSpawn(out VehicleSpawn spawn)
	{
		if(m_CurrentVehicles.Count == 0 && vehicleSpawns.Length > 0)
			{
				int index = UnityEngine.Random.Range(0, vehicleSpawns.Length);
				spawn = vehicleSpawns[index];
				return true;
			}
		spawn = null;
		return false;
	}

	private List<VehicleAIScript> m_CurrentVehicles = new List<VehicleAIScript>();

	public void RegisterVehicle(VehicleAIScript input, bool isAdd)
	{
		if(isAdd)
			m_CurrentVehicles.Add(input);
		else
		{
			if(m_CurrentVehicles.Contains(input))
				m_CurrentVehicles.Remove(input);
			else
				Debug.LogWarning("Traffic: Attempted to remove non-existing vehicle from Road: "+gameObject.name);
		}
	}
}

[Serializable]
public class VehicleSpawn
{
	public Transform spawn;
	public NavConnectionScript destination;
}
