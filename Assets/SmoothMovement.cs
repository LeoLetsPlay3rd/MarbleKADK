using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public Transform targetTransform;
    public float smoothness = 2f;

    void Update()
    {
        if (targetTransform != null)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetTransform.rotation, smoothness * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("Target position is not assigned");
        }
    }

}
