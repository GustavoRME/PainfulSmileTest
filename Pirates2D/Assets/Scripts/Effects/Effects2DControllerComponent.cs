using UnityEngine;


public class Effects2DControllerComponent : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _shipRenderer = null;

    [Space]
    [SerializeField] private Sprite _defaultShip = null;
    [SerializeField] private Sprite _shipwreck = null;
    [SerializeField] private Sprite[] _damagedShips = null;

    [Space]
    [SerializeField] private Effects2DComponent[] _explosionPrefabs = null;
    [SerializeField] private Transform[] _explosionSpots = null;

    private int _shipIndex;
    private int _fullHealth;
    private int _healthToDamage;

    private bool _isLive;

    private PoolManagerComponent _poolManager;
    
    private void Start() => _poolManager = FindObjectOfType<PoolManagerComponent>();
        
    public void LiveShip(int fullHealth)
    {
        _shipRenderer.sprite = _defaultShip;
        _isLive = true;

        if (_damagedShips != null)
        {
            _fullHealth = fullHealth;
            _healthToDamage = _fullHealth / _damagedShips.Length;
            _shipIndex = 0;
        }
    }
    public void DamageShip2D(int health)
    {
        if(_damagedShips != null)
        {            
            if(CanDamageShip(health))
            {                
                _shipRenderer.sprite = _damagedShips[_shipIndex];

                _shipIndex = Mathf.Clamp(_shipIndex + 1, 0, _damagedShips.Length - 1);

                Explosion2D();                
            }          
        }
    }    
    public void Explosion2D()
    {
        if(_explosionPrefabs != null && _explosionSpots != null)
        {
            if(_isLive)
            {
                int indexExplosion = Random.Range(0, _explosionPrefabs.Length);
                int indexSpot = Random.Range(0, _explosionSpots.Length);

                Effects2DComponent effect2D = _poolManager.GetComponentFromPool<Effects2DComponent>(_explosionPrefabs[indexExplosion].gameObject);
                Vector3 spotPosition = _explosionSpots[indexSpot].position;

                effect2D.StartEffect(spotPosition);
            }
        }
    }
    public void WreckShip()
    {
        _shipRenderer.sprite = _shipwreck;

        _isLive = false;
    }

    private bool CanDamageShip(int health) => health % _healthToDamage == 0;
}
