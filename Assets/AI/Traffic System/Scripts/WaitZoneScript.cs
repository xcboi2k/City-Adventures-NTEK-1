using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitZoneScript : MonoBehaviour
{
    public TrafficType type;
	public WaitZoneScript opposite;

    private bool m_CanPass = false;

	public bool canPass 
	{ 
		get {return m_CanPass;} 
		set {m_CanPass = value;}
	}
}
