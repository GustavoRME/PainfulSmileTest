using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ChaserComponent : MonoBehaviour
{
    public enum ChaseMode { Shooter, Explosive};

    public ChaseMode chaseMode = ChaseMode.Explosive;

    public int explosionDamage = 5;

    public float sightDistance = 10.0f;
    public float distanceToStop = 10.0f;
    public float movementSpeed = 100.0f;

    private Movement _movement;
    private HealthComponent _health;    
    private CameraShakeComponent _camera;

    private bool _canApproach;
    private Transform target = null;

    private void Awake() 
    { 
        _movement = new Movement(transform, GetComponent<Rigidbody2D>());
        _health = GetComponent<HealthComponent>();        

        _camera = FindObjectOfType<CameraShakeComponent>();
        _canApproach = true;

        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void OnEnable()
    {
        enabled = true;        
        _movement.UnfreezeRigidBody();
    }
    private void Update()
    {
        if(_health.Islive())
        {
            if(IsSight())
            {
                if(chaseMode == ChaseMode.Shooter)
                {
                    _canApproach = Vector3.Distance(transform.position, target.position) > distanceToStop;
                }
            
                if(_canApproach)
                {
                    Vector2 direction = target.position - transform.position;

                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
                    _movement.Rotate(angle);
                    _movement.MoveForward(direction, movementSpeed);
                }            
            }            
        }

        if(!_health.Islive() || !IsSight())
        {
            _movement.FreezeRigidbody();
        }                
    }    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(chaseMode == ChaseMode.Explosive)
        {
            if (collision.gameObject.CompareTag(target.tag))
            {
                if (collision.gameObject.TryGetComponent(out HealthComponent shipHealth))
                {
                    shipHealth.TakeDamage(explosionDamage);
                    _health.TakeDamage(explosionDamage);

                    if(_camera)
                        _camera.ShakeCamera();             
                }
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        if(target)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, sightDistance);

            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + transform.right * distanceToStop);
        }
    }

    public void StopMovement()
    {
        enabled = false;
        _movement.FreezeRigidbody();
    }

    private bool IsSight() => Vector3.Distance(transform.position, target.position) < sightDistance;    
    
}
