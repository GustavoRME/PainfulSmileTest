using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CannonBallComponent : MonoBehaviour
{
    [SerializeField] private float _speed = 0.0f;
    [SerializeField] private float _lifeTime = 15.0f;
    [SerializeField] private TrailRenderer _trail;

    private Rigidbody2D _rb;
    private string _targetTag;
    private int _damage;

    private void Awake() => _rb = GetComponent<Rigidbody2D>();            
    private void OnEnable()
    {
        if(_rb)
        {
            Vector3 force = transform.right * _speed;

            _rb.velocity = Vector2.zero;
            _rb.AddForce(force);                        
        }      
    }    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_targetTag))
        {                                    
            if(collision.TryGetComponent(out HealthComponent healthShip))
            {
                healthShip.TakeDamage(_damage);
            }

            Disable();                               
        }
    }
   
    public void SetUp(Vector3 startPosition, Vector2 direction, int damage, string targetName)
    {
        transform.position = startPosition;
        transform.right = direction;
        _damage = damage;
        _targetTag = targetName;
    }
    public void Throw()
    {       
        Invoke("Disable", _lifeTime);                
        gameObject.SetActive(true);
    }

    private void Disable()
    {
        CancelInvoke();
        _trail.Clear();
        gameObject.SetActive(false);
    }
}
