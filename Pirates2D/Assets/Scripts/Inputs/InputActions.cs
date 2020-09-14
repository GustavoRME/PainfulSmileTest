// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b7e5efef-6667-433b-987f-e40ec4554472"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""df618123-ce23-46fb-9d74-f7e049dafeaa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SingleFire"",
                    ""type"": ""Button"",
                    ""id"": ""8e3504ff-10df-443d-abaf-ab9f2d0ab7b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TripleFire"",
                    ""type"": ""Button"",
                    ""id"": ""376c3d39-cf42-46a7-921e-bae2ab34aadc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WAD"",
                    ""id"": ""7c03e910-bf03-4a18-ba2c-301298fe7ca1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8f7090dd-078b-4f69-8358-79e23744cbd7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cddc1a67-6db1-438b-a292-b38a89dc7ad5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c89f2882-ec60-45b2-a8ff-d4653f80bcd6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b7635132-30ad-49d3-be30-417970e8dfd7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""d79f128c-10be-43c5-b8c8-fe20c7efb918"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e450138d-fdc8-4eb6-8594-110577c07471"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9875500c-c3c6-427c-b861-c09bc48ed066"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6cc88cc6-3bed-4c06-96b8-181ce99b9fae"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d18b7bfe-6a92-4d5b-b803-dcc7fb35a35b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1e45fbda-7158-491e-b39d-703bd0370aad"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""SingleFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""150bfd41-e9b5-405c-bc27-b9d5b1ec90ae"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""TripleFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Standard"",
            ""bindingGroup"": ""Standard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_SingleFire = m_Player.FindAction("SingleFire", throwIfNotFound: true);
        m_Player_TripleFire = m_Player.FindAction("TripleFire", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_SingleFire;
    private readonly InputAction m_Player_TripleFire;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @SingleFire => m_Wrapper.m_Player_SingleFire;
        public InputAction @TripleFire => m_Wrapper.m_Player_TripleFire;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @SingleFire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSingleFire;
                @SingleFire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSingleFire;
                @SingleFire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSingleFire;
                @TripleFire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleFire;
                @TripleFire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleFire;
                @TripleFire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleFire;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @SingleFire.started += instance.OnSingleFire;
                @SingleFire.performed += instance.OnSingleFire;
                @SingleFire.canceled += instance.OnSingleFire;
                @TripleFire.started += instance.OnTripleFire;
                @TripleFire.performed += instance.OnTripleFire;
                @TripleFire.canceled += instance.OnTripleFire;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_StandardSchemeIndex = -1;
    public InputControlScheme StandardScheme
    {
        get
        {
            if (m_StandardSchemeIndex == -1) m_StandardSchemeIndex = asset.FindControlSchemeIndex("Standard");
            return asset.controlSchemes[m_StandardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSingleFire(InputAction.CallbackContext context);
        void OnTripleFire(InputAction.CallbackContext context);
    }
}
