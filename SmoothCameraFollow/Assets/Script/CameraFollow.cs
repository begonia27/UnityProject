using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float SmoothSpeed = 0.125f;
    public Vector3 Offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = Target.position + Offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);

        transform.position = SmoothedPosition;

        transform.LookAt(Target);
    }
}
