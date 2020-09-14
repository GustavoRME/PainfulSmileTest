using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 10.0f;
    [SerializeField] private float _rotationSpeed = 10.0f;    

    public Vector2 InputAxis { get; set; }
    private Movement _movement;

    private void Start() => _movement = new Movement(transform, GetComponent<Rigidbody2D>());
    private void FixedUpdate()
    {        
        if(InputAxis.magnitude > 0)
        {           
            _movement.MoveForward(transform.up * InputAxis.y, _movementSpeed);
            _movement.RotatePlus(-InputAxis.x, _rotationSpeed);
        }
    }

    public void StopMovement()
    {
        enabled = false;
        _movement.FreezeRigidbody();
    }
}
