using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class NavConnectionScript : MonoBehaviour
{
    private NavSectionScript m_NavSection;
	public NavSectionScript navSection 
	{
		get { return m_NavSection; }
		set { m_NavSection = value; }
	}

    public NavConnectionScript[] outConnections;

    public NavConnectionScript GetOutConnection()
	{
		if(outConnections.Length > 0)
		{
			int index = UnityEngine.Random.Range(0, outConnections.Length);
			return outConnections[index];
		}
		return null;
	}
}
