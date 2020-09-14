using UnityEngine;

public class InputShooterComponent : ShooterBehaviour
{
    [Space]
    [SerializeField] private Transform _frontCannon = null;    
    [SerializeField] private Transform[] _sideCannons = null;
    
    public void SingleShoot() => Shoot(_frontCannon.position, _frontCannon.up);
    public void TripleShoot()
    {        
        Vector3[] positions = new Vector3[_sideCannons.Length];
        Vector3[] directions = new Vector3[_sideCannons.Length];

        for (int i = 0; i < _sideCannons.Length; i++)
        {
            positions[i] = _sideCannons[i].position;
            directions[i] = _sideCannons[i].right;
        }

        Shoot(positions, directions, 3);
    }
        
}
