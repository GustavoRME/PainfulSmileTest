using UnityEngine;

public abstract class ShooterBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _cannonBall = null;
    
    [Space]
    [SerializeField] protected string _targetName = "";
    [SerializeField] private int _damage = 1;
    [SerializeField] private float _fireRate = 0.5f;

    private PoolManagerComponent _poolManager;
    private bool _canShoot = true;

    protected virtual void Start() => _poolManager = FindObjectOfType<PoolManagerComponent>();

    protected void Shoot(Vector3 startPosition, Vector3 direction)
    {
        if(_poolManager)
        {
            if(_canShoot)
            {
                CannonBallComponent cannonBall = GetCannonBall();

                if(cannonBall)
                {
                    cannonBall.SetUp(startPosition, direction, _damage, _targetName);
                    cannonBall.Throw();

                    _canShoot = false;
                    Invoke("EnableToShoot", _fireRate);
                }
            }
        }
    }
    protected void Shoot(Vector3[] startPositions, Vector3[] directions, int amount)
    {
        if(_poolManager)
        {
            if(_canShoot)
            {
                for (int i = 0; i < amount; i++)
                {
                    CannonBallComponent cannonBall = GetCannonBall();

                    if(cannonBall)
                    {
                        cannonBall.SetUp(startPositions[i], directions[i], _damage,_targetName);
                        cannonBall.Throw();
                    }
                }
            
                _canShoot = false;
                Invoke("EnableToShoot", _fireRate);
            }
        }
    }

    private CannonBallComponent GetCannonBall() => _poolManager.GetComponentFromPool<CannonBallComponent>(_cannonBall);
    private void EnableToShoot() => _canShoot = true;
}
