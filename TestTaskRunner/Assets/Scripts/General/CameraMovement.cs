using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    private Vector3 _offset;
    private Vector3 _cameraRotation;

    private void Awake()
    {
        _offset = playerTransform.position - transform.position;
    }
    private void Update()
    {
        transform.position = playerTransform.position - _offset;
        _cameraRotation.x = transform.eulerAngles.x;
        _cameraRotation.y = playerTransform.eulerAngles.y;
        _cameraRotation.z = transform.eulerAngles.z;
        transform.eulerAngles = _cameraRotation;
    }
}
