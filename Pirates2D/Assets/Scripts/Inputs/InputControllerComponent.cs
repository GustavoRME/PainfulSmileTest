using UnityEngine;
using UnityEngine.Events;

public class InputControllerComponent : MonoBehaviour
{
    private InputActions _inputs;

    [SerializeField] private UnityEvent<Vector2> _onMovementAction = null;
    [SerializeField] private UnityEvent _onSingleFireAction = null;
    [SerializeField] private UnityEvent _onTripleFireAction = null;        

    private void Awake()
    {
        _inputs = new InputActions();

        _inputs.Player.Movement.performed += Movement_performed;
        _inputs.Player.SingleFire.performed += SingleFire_performed;
        _inputs.Player.TripleFire.performed += TripleFire_performed;        
    }
    private void OnEnable() => _inputs.Enable();        
    private void OnDisable() => _inputs.Disable();
    
    private void Movement_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) => _onMovementAction?.Invoke(obj.ReadValue<Vector2>()); 
    private void SingleFire_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) =>_onSingleFireAction?.Invoke();     
    private void TripleFire_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) => _onTripleFireAction?.Invoke();   
    
}
