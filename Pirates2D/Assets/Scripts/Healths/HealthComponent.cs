using UnityEngine;
using UnityEngine.Events;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    
    [Space(20f)]
    [SerializeField] private UnityEvent<int> _onEnable = null;
    [SerializeField] private UnityEvent<int> _onTakeDamage = null;
    [SerializeField] private UnityEvent _onDie = null;

    private int _currentHealth;
    private bool _isDead = false;

    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();

        UnityAction increaseScore = new UnityAction(FindObjectOfType<ScoreManagerComponent>().IncreaseScore);
        _onDie.AddListener(increaseScore);
    }

        
    private void OnEnable()
    {
        _currentHealth = _health;
        _collider.enabled = true;
        _isDead = false;

        _onEnable?.Invoke(_currentHealth);
    }
        
    public void TakeDamage(int damage)
    {
        if(!_isDead)
        {
            _currentHealth -= damage;
            _onTakeDamage?.Invoke(_currentHealth);

            if(_currentHealth <= 0)
            {
                Die();                
            }            
        }        
    }
    public void Die()
    {
        _onDie?.Invoke();
        _isDead = true;

        _collider.enabled = false;
    }
    public bool Islive() => !_isDead;
}
