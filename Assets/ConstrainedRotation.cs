using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstrainedRotation : MonoBehaviour
{
    public Vector3 minRotation = new Vector3(-90f, -90f, -90f); // Minimum rotation for each axis
    public Vector3 maxRotation = new Vector3(90f, 90f, 90f); // Maximum rotation for each axis

    void Update()
    {
        // Get the current Euler angles of the rotation
        Vector3 currentRotation = transform.eulerAngles;

        // Clamp the rotation within the specified bounds
        float clampedXRotation = ClampAngle(currentRotation.x, minRotation.x, maxRotation.x);
        float clampedYRotation = ClampAngle(currentRotation.y, minRotation.y, maxRotation.y);
        float clampedZRotation = ClampAngle(currentRotation.z, minRotation.z, maxRotation.z);

        // Apply the clamped rotation to the object
        transform.eulerAngles = new Vector3(clampedXRotation, clampedYRotation, clampedZRotation);
    }

    float ClampAngle(float angle, float min, float max)
    {
        // Normalize the angle to be within -180 and 180 degrees
        angle = Mathf.Repeat(angle + 180f, 360f) - 180f;

        // Clamp the angle within the specified bounds
        return Mathf.Clamp(angle, min, max);
    }
}
