using UnityEngine;
using UnityEngine.Events;

public class InputControllerComponent : MonoBehaviour
{
    private InputActions _inputs;

    [SerializeField] private UnityEvent<Vector2> OnMovementAction = null;
    [SerializeField] private UnityEvent OnSingleFireAction = null;
    [SerializeField] private UnityEvent OnTripleFireAction = null;

    private void Awake()
    {
        _inputs = new InputActions();

        _inputs.Player.Movement.performed += Movement_performed;
        _inputs.Player.SingleFire.performed += SingleFire_performed;
        _inputs.Player.TripleFire.performed += TripleFire_performed;
    }
    private void OnEnable() => _inputs.Enable();        
    private void OnDisable() => _inputs.Disable();
    
    private void Movement_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) => OnMovementAction?.Invoke(obj.ReadValue<Vector2>());
    private void SingleFire_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) => OnSingleFireAction?.Invoke();
    private void TripleFire_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) => OnTripleFireAction?.Invoke();        
}
