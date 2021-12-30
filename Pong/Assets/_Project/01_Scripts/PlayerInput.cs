//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/_Project/01_Scripts/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""WASD"",
            ""id"": ""2971e89f-9b52-4e10-b1f7-865536eb964f"",
            ""actions"": [
                {
                    ""name"": ""PaddleMove"",
                    ""type"": ""Value"",
                    ""id"": ""944d0397-bc8d-4a2b-a9d6-e6173efbf4c1"",
                    ""expectedControlType"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c35ab455-3f8f-4c2b-9cc8-850873463508"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""a60b38d2-e2b4-484c-a296-0419ddecbcb9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2d2a906a-290a-4ba8-b707-58ea6dc21a89"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""PaddleMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4a16b706-6f0b-4525-aa36-d5ea1d606727"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""PaddleMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""82564e82-3317-47c4-b47b-3ce7d12d3565"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Arrows"",
            ""id"": ""1696d6eb-bfe1-4f21-a512-7ebe1e6280df"",
            ""actions"": [
                {
                    ""name"": ""PaddleMove"",
                    ""type"": ""Value"",
                    ""id"": ""4f15b1d6-992e-4f6c-8fb0-db19f5ecad38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""629b7b5d-10c2-46b7-85fb-52d3b0fee230"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""c684dfa2-ef56-4cee-9492-30929053b817"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PaddleMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3741b2ba-ce7d-45b3-85c4-2341ab5b92ca"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""PaddleMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5dc6a5ae-3456-4438-a2c2-3feb347e73eb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""PaddleMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4f5bb7b7-30e6-4603-8f15-ef3848e92a4c"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player"",
            ""bindingGroup"": ""Player"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // WASD
        m_WASD = asset.FindActionMap("WASD", throwIfNotFound: true);
        m_WASD_PaddleMove = m_WASD.FindAction("PaddleMove", throwIfNotFound: true);
        m_WASD_Shoot = m_WASD.FindAction("Shoot", throwIfNotFound: true);
        // Arrows
        m_Arrows = asset.FindActionMap("Arrows", throwIfNotFound: true);
        m_Arrows_PaddleMove = m_Arrows.FindAction("PaddleMove", throwIfNotFound: true);
        m_Arrows_Shoot = m_Arrows.FindAction("Shoot", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // WASD
    private readonly InputActionMap m_WASD;
    private IWASDActions m_WASDActionsCallbackInterface;
    private readonly InputAction m_WASD_PaddleMove;
    private readonly InputAction m_WASD_Shoot;
    public struct WASDActions
    {
        private @PlayerInput m_Wrapper;
        public WASDActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PaddleMove => m_Wrapper.m_WASD_PaddleMove;
        public InputAction @Shoot => m_Wrapper.m_WASD_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_WASD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WASDActions set) { return set.Get(); }
        public void SetCallbacks(IWASDActions instance)
        {
            if (m_Wrapper.m_WASDActionsCallbackInterface != null)
            {
                @PaddleMove.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnPaddleMove;
                @PaddleMove.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnPaddleMove;
                @PaddleMove.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnPaddleMove;
                @Shoot.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_WASDActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PaddleMove.started += instance.OnPaddleMove;
                @PaddleMove.performed += instance.OnPaddleMove;
                @PaddleMove.canceled += instance.OnPaddleMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public WASDActions @WASD => new WASDActions(this);

    // Arrows
    private readonly InputActionMap m_Arrows;
    private IArrowsActions m_ArrowsActionsCallbackInterface;
    private readonly InputAction m_Arrows_PaddleMove;
    private readonly InputAction m_Arrows_Shoot;
    public struct ArrowsActions
    {
        private @PlayerInput m_Wrapper;
        public ArrowsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PaddleMove => m_Wrapper.m_Arrows_PaddleMove;
        public InputAction @Shoot => m_Wrapper.m_Arrows_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Arrows; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ArrowsActions set) { return set.Get(); }
        public void SetCallbacks(IArrowsActions instance)
        {
            if (m_Wrapper.m_ArrowsActionsCallbackInterface != null)
            {
                @PaddleMove.started -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnPaddleMove;
                @PaddleMove.performed -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnPaddleMove;
                @PaddleMove.canceled -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnPaddleMove;
                @Shoot.started -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_ArrowsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PaddleMove.started += instance.OnPaddleMove;
                @PaddleMove.performed += instance.OnPaddleMove;
                @PaddleMove.canceled += instance.OnPaddleMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public ArrowsActions @Arrows => new ArrowsActions(this);
    private int m_PlayerSchemeIndex = -1;
    public InputControlScheme PlayerScheme
    {
        get
        {
            if (m_PlayerSchemeIndex == -1) m_PlayerSchemeIndex = asset.FindControlSchemeIndex("Player");
            return asset.controlSchemes[m_PlayerSchemeIndex];
        }
    }
    public interface IWASDActions
    {
        void OnPaddleMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IArrowsActions
    {
        void OnPaddleMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}