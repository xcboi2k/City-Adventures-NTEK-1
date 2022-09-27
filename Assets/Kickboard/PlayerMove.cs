using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Animator animator;
    public float speed;
    public float rotationSpeed;

    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = this.GetComponent<Animator>();
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


        if (Input.GetKey ("w"))
        {
            animator.SetBool("isForward", true);
        }
        if (!Input.GetKey ("w"))
        {
            animator.SetBool("isForward", false);
        }
        if (Input.GetKey ("s"))
        {
            animator.SetBool("isBackward", true);
        }
        if (!Input.GetKey ("s"))
        {
            animator.SetBool("isBackward", false);
        }
    }
}
