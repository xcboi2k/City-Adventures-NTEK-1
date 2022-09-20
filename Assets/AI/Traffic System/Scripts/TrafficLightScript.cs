using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightScript : MonoBehaviour
{
    public MeshRenderer RedLight;
	public MeshRenderer GreenLight;

	public void SetLight(bool input)
	{
		GreenLight.material.SetColor("_Color", input ? Color.green : Color.red );
	}
}
