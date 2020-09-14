using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterComponent : ShooterBehaviour
{
    [SerializeField] private Transform _frontCannon = null;

    [Space]
    [SerializeField] private float _rangeToShoot = 1.0f;

    private void Update()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(_frontCannon.position, _frontCannon.right, _rangeToShoot);

        if(hit2D)
        {
            if(hit2D.collider.CompareTag(_targetName))
                Shoot(_frontCannon.position, _frontCannon.right);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if(_frontCannon)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(_frontCannon.position, _frontCannon.position +_frontCannon.right * _rangeToShoot);
        }
    }

    public void StopShoot() => enabled = false;
}
