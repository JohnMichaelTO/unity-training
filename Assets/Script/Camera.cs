using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform targetObject;
    public float smoothTime = 0.1f;
    public float speed = 3.0f;

    public float followDistance = 3f;
    public float verticalBuffer = -15f;
    public float horizontalBuffer = 0f;

    private Vector3 velocity = Vector3.zero;

    public Quaternion rotation = Quaternion.identity;

    public float yRotation = 0.0f;

    void Update()
    {
        Vector3 targetPosition = targetObject.TransformPoint(new Vector3(horizontalBuffer, followDistance, verticalBuffer));
        // transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothTime);
        transform.eulerAngles = new Vector3(0, targetObject.transform.eulerAngles.y, 0);
    }
}
