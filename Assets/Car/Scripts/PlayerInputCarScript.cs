using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputCarScript : MonoBehaviour
{
    public float throttle;
    public float steer;

    // Update is called once per frame
    void Update()
    {
        throttle = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
    }
}
