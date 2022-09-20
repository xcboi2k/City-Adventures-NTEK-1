using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Vector2 MouseMovement()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        return new Vector2(x, y);
    }

    Vector2 KeyboardAxis()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        return new Vector2(x, y);
    }

    bool KeyboardRun()
    {
        bool pressed = Input.GetButton("Jump");

        return pressed;
    }


    public GameObject view;
    public float viewSpeed;
    Vector3 viewRotation;
    void CharacterLook(Vector2 mouseMovement)
    {
        mouseMovement *= viewSpeed * Time.deltaTime;

        viewRotation.x -= mouseMovement.y;
        viewRotation.y += mouseMovement.x;

        viewRotation.x = Mathf.Clamp(viewRotation.x, -90, 70);

        view.transform.position = animator.GetBoneTransform(HumanBodyBones.Head).position;

        view.transform.rotation = Quaternion.Lerp(view.transform.rotation, Quaternion.Euler(viewRotation), 25f * Time.deltaTime);
    }

    public GameObject body;
    public float bodySpeed;

    public float viewAngle;
    public float bodyAngle;
    public float angle;

    public Quaternion bodyRotation;
    void CharacterRotation()
    {
        viewAngle = view.transform.rotation.eulerAngles.y;
        viewAngle = viewAngle > 180f ? viewAngle - 360f : viewAngle;

        bodyAngle = body.transform.rotation.eulerAngles.y;
        bodyAngle = bodyAngle > 180f ? bodyAngle - 360f : bodyAngle;

        angle = bodyAngle - viewAngle;
        angle = angle > 180f ? angle - 360f : angle;

        if(angle >= 80f || angle <= -80 || controller.velocity.magnitude >= 0.1f)
        {
            bodyRotation = Quaternion.Euler(0f, viewAngle, 0f);
        }

        body.transform.rotation = Quaternion.Lerp(body.transform.rotation, bodyRotation, bodySpeed * Time.deltaTime);
    }

    public bool onTheGround;
    public Vector3 groundNormal;
    void GroundCheck()
    {
        Ray ray = new Ray(controller.transform.position + (Vector3.up), Vector3.down);
        RaycastHit hit;
        int groundLayer = LayerMask.GetMask("Ground");

        onTheGround = Physics.CheckSphere(controller.transform.position + new Vector3(0f, 0.48f, 0f), 0.50f, groundLayer);

        if(Physics.Raycast(ray, out hit, 10f, groundLayer))
        {
            if (onTheGround)
                groundNormal = hit.normal;
            else
                groundNormal = Vector3.up;
        }
    }

    private Vector3 movement;
    private Vector3 movementAdjustment;
    public float walkSpeed = 3f;
    public float runSpeed = 5f;
    private float moveSpeed;

    void CharacterPosition()
    {
        if (onTheGround)
        {
            if (KeyboardAxis().magnitude != 0)
            {
                movement = (body.transform.right * KeyboardAxis().x + body.transform.forward * KeyboardAxis().y).normalized;
                movement = Vector3.ProjectOnPlane(movement, groundNormal);

                if (KeyboardRun())
                    moveSpeed = Mathf.Lerp(moveSpeed, runSpeed, 8f * Time.deltaTime);
                else
                    moveSpeed = Mathf.Lerp(moveSpeed, walkSpeed, 8f * Time.deltaTime);
            }
            else
            {
                moveSpeed = Mathf.Lerp(moveSpeed, 0f, 4f * Time.deltaTime);
            }
            movementAdjustment.y = 0f;
        }
        else
        {
            movementAdjustment.y -= 20f * Time.deltaTime;
        }

        controller.Move(((movement.normalized * moveSpeed) + movementAdjustment) * Time.deltaTime);
    }

    public Vector3 characterVelocity;
    void CharacterAnimation()
    {
        characterVelocity = body.transform.InverseTransformDirection(controller.velocity);

        animator.SetFloat("x", characterVelocity.x, 0.05f, Time.deltaTime);
        animator.SetFloat("z", characterVelocity.z, 0.05f, Time.deltaTime);
        animator.SetFloat("y", characterVelocity.y, 0.05f, Time.deltaTime);
    }


    CharacterController controller;
    Animator animator;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = body.GetComponent<Animator>();
    }
    private void Update()
    {
        GroundCheck();

        CharacterLook(MouseMovement());
        CharacterRotation();
        CharacterPosition();
        CharacterAnimation();
    }
}
