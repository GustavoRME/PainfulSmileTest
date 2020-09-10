using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CannonBallComponent : MonoBehaviour
{
    [SerializeField] private float _speed = 0.0f;
    [SerializeField] private float _damage = 0.0f;

    [SerializeField] private float _lifeTime = 15.0f;

    private Rigidbody2D _rb;
    private Vector2 _direction;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _direction = Vector2.zero;
    }    
    private void OnEnable()
    {
        if(_rb)
        {
            Vector3 force = _direction * _speed;

            _rb.velocity = Vector2.zero;
            _rb.AddForce(force);

            print("Force " + force);
        }
    }    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("CannonBall"))
        {
            CancelInvoke();
            Disable();            
        }
    }

    public void SetPosition(Vector3 position) => transform.position = position;
    public void SetDirection(Vector2 direction) => _direction = direction;
    public void Enable()
    {       
        Invoke("Disable", _lifeTime);
                
        gameObject.SetActive(true);
    }

    private void Disable() => gameObject.SetActive(false);
}
