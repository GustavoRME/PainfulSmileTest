using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 10.0f;
    [SerializeField] private float _rotationSpeed = 10.0f;
    
    public Vector2 Axis { get; set; }

    private void Update()
    {
        if(Axis.magnitude > 0.0f)
        {
            MoveForward();
            RotateZ();
        }
    }

    private void MoveForward()
    {
        if(Axis.y > 0.0f)
        {
            Vector3 forward = transform.up * Axis.y * _movementSpeed * Time.deltaTime;

            transform.position += forward;
        }
    }
    private void RotateZ()
    {
        if(Axis.x != 0.0f)
        {
            Vector3 eulerZ = transform.forward * -Axis.x * _rotationSpeed * Time.deltaTime;

            transform.Rotate(eulerZ);
        }
    }
}
