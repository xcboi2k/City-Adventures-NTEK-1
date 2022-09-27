using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarCameraScript : MonoBehaviour
{
    public float rotationSpeed;
    float mouseX, mouseY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseX = Mathf.Clamp(mouseX, -45f, 45f);

        transform.localRotation = Quaternion.Euler(0, mouseX, 0);
    }
}
