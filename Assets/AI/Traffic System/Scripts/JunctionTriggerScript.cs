using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunctionTriggerScript : MonoBehaviour
{
    public enum TriggerType { Enter, Exit }

    public TriggerType type;

    private JunctionScript m_Junction;
	public JunctionScript junction 
	{
		get { return m_Junction; }
		set { m_Junction = value; }
	}

	// public void TriggerJunction()
	// {
    //     junction.TryChangePhase();
	// }
}
