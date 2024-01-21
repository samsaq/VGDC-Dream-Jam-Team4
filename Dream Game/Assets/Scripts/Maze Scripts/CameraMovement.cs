using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 velocity = Vector3.zero;
    [SerializeField] private GameObject cloud;
    private Vector3 cloudPosition;
    private float smoothTime = 0.2f;

    void Update()
    {
        cloudPosition = new Vector3(cloud.transform.position.x, cloud.transform.position.y, -10);
        this.transform.position = Vector3.SmoothDamp(this.transform.position, cloudPosition, ref velocity, smoothTime);
    }
}
