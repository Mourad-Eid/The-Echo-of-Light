// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""c5f590d1-919a-45ee-80fc-36e02ab0623e"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1a6cd0a9-cc5a-4214-88ce-7a5c06e0e16a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d6227b2d-af3b-405e-8b28-675e375d3eb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""afdde981-cab2-4017-9157-ae9f467ecfc1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d5fdd8b0-604e-4b6c-8fda-f69f356524ae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MeleeHit"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6cb3418f-131b-4506-b138-acf868221bb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerShooting"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f2a4e056-1e57-4477-b20e-06c1d341629b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""sideWalk"",
                    ""id"": ""4c35a591-7e86-4d2e-9119-6990d9a856cf"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9f135437-f103-4de5-aa98-13e3c915d8ef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""df28dde4-d6c2-408f-9023-c4c8e63d93a0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""51f47f95-69db-4180-b149-a9fb6850f72b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1e1b0d5-2075-49d8-aa8f-a018ed7659d1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4490fdff-f1fb-4bd6-b2e3-46f8d8511465"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""910a174d-9d30-4b85-9078-263022704407"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MeleeHit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b030166-2a7c-43a3-bc5a-97ccc22090b0"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerShooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Walk = m_Land.FindAction("Walk", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_Shoot = m_Land.FindAction("Shoot", throwIfNotFound: true);
        m_Land_MousePosition = m_Land.FindAction("MousePosition", throwIfNotFound: true);
        m_Land_MeleeHit = m_Land.FindAction("MeleeHit", throwIfNotFound: true);
        m_Land_TriggerShooting = m_Land.FindAction("TriggerShooting", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Walk;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Shoot;
    private readonly InputAction m_Land_MousePosition;
    private readonly InputAction m_Land_MeleeHit;
    private readonly InputAction m_Land_TriggerShooting;
    public struct LandActions
    {
        private @PlayerActionControls m_Wrapper;
        public LandActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Land_Walk;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Shoot => m_Wrapper.m_Land_Shoot;
        public InputAction @MousePosition => m_Wrapper.m_Land_MousePosition;
        public InputAction @MeleeHit => m_Wrapper.m_Land_MeleeHit;
        public InputAction @TriggerShooting => m_Wrapper.m_Land_TriggerShooting;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_LandActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnWalk;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnShoot;
                @MousePosition.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMousePosition;
                @MeleeHit.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMeleeHit;
                @MeleeHit.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMeleeHit;
                @MeleeHit.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMeleeHit;
                @TriggerShooting.started -= m_Wrapper.m_LandActionsCallbackInterface.OnTriggerShooting;
                @TriggerShooting.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnTriggerShooting;
                @TriggerShooting.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnTriggerShooting;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @MeleeHit.started += instance.OnMeleeHit;
                @MeleeHit.performed += instance.OnMeleeHit;
                @MeleeHit.canceled += instance.OnMeleeHit;
                @TriggerShooting.started += instance.OnTriggerShooting;
                @TriggerShooting.performed += instance.OnTriggerShooting;
                @TriggerShooting.canceled += instance.OnTriggerShooting;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    public interface ILandActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnMeleeHit(InputAction.CallbackContext context);
        void OnTriggerShooting(InputAction.CallbackContext context);
    }
}
