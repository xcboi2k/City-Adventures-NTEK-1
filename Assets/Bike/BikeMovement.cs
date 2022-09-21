using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{

    CharacterController controller;
    public float rotationSpeed;
    public float speed;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (transform != null)
         {
             transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
             var forward = transform.TransformDirection(Vector3.forward);
             float curSpeed = speed * Input.GetAxis("Vertical");
             controller.SimpleMove(forward * curSpeed);
         }
    }
}
