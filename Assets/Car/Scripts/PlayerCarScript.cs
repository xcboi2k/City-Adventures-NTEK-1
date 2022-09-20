using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInputCarScript))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerCarScript : MonoBehaviour
{
    public PlayerInputCarScript input;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;

    public float strengthCoefficient = 10000f;
    public float maxTurn = 10f;

    public Transform CM;
    public Rigidbody RB;

    void Start(){
        input = GetComponent<PlayerInputCarScript>();
        RB = GetComponent<Rigidbody>();

        if(CM){
            RB.centerOfMass = CM.position;
        }
    }

    // Update is called once per frame
    void FixedUpdate(){
        foreach(WheelCollider wheel in throttleWheels){
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * input.throttle;
        }

        foreach(WheelCollider wheel in steeringWheels){
            wheel.steerAngle = maxTurn * input.steer;
        }
    }
}
