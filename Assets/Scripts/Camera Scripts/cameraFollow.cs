using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform cameraTarget;
    public float smoothSpeed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;

    void FixedUpdate()
    {
        Vector3 desiredPosition = cameraTarget.transform.position + dist;
        Vector3 fPos = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = fPos;
        transform.LookAt(lookTarget.position);
        
    }
}
