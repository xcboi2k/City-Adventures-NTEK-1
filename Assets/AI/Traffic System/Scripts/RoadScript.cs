using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : NavSectionScript
{
    [Header("Road")]
	public Transform[] pedestrianSpawns;

    public bool TryGetPedestrianSpawn(out Transform spawn)
	{
		if(pedestrianSpawns.Length > 0)
		{
			int index = UnityEngine.Random.Range(0, pedestrianSpawns.Length);
			spawn = pedestrianSpawns[index];
			return true;
		}
		spawn = null;
		return false;
	}
}
