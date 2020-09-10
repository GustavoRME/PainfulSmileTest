using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterComponent : MonoBehaviour
{
    [SerializeField] private CannonBallComponent _cannonBall = null;

    [Space(1.0f)]
    [SerializeField] private Transform _frontCannon = null;
    [SerializeField] private Transform _sideCannon = null;

    [SerializeField] private float _spaceBetweenCannons = 100.0f;

    private PoolManagerComponent _poolManager;
    
    private void Start()
    {
        _poolManager = FindObjectOfType<PoolManagerComponent>();
    }

    public void SingleShoot() => ShootCannonBall(_frontCannon.position, 1, _frontCannon.up);
    public void TripleShoot() => ShootCannonBall(_sideCannon.position, 3, _sideCannon.right, _spaceBetweenCannons);

    private void ShootCannonBall(Vector3 startPosition, int amount, Vector3 direction, float spaceBetweenCannon = 0.0f)
    {
        if(_poolManager)
        {
            for (int i = 0; i < amount; i++)
            {
                var cannonBall = _poolManager.GetComponent<CannonBallComponent>(_cannonBall.gameObject);

                if (cannonBall)
                {
                    Debug.Log("Direction " + direction.ToString());
                    
                    cannonBall.SetPosition(startPosition);
                    cannonBall.SetDirection(direction);
                    cannonBall.Enable();
                }
                
            }
        }
    }
}
