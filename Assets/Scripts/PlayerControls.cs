// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""522a5967-25cf-478e-8f84-54f320cba32d"",
            ""actions"": [
                {
                    ""name"": ""mouse"",
                    ""type"": ""Value"",
                    ""id"": ""9f448840-650c-4eee-8db3-4edf56666c6d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""up"",
                    ""type"": ""Button"",
                    ""id"": ""1423bde5-43a2-42c9-b9fa-7b1b4bcdad0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.1)""
                },
                {
                    ""name"": ""down"",
                    ""type"": ""Button"",
                    ""id"": ""4e3097e0-2804-4e18-adbc-31f694fce712"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2c28044-bcb1-45ef-ac80-8eb135b1ed68"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b376a51-5c63-4065-9357-824743e0103f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe1e05b4-0001-4814-9ae4-b394a6dbe631"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c78f3ad9-dce7-447d-b90f-1b8a9052ebcc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c4beb0e-a419-4947-930a-54f274494b66"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bd69e00-95d9-4b54-a518-c873d6c0d899"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_mouse = m_Player.FindAction("mouse", throwIfNotFound: true);
        m_Player_up = m_Player.FindAction("up", throwIfNotFound: true);
        m_Player_down = m_Player.FindAction("down", throwIfNotFound: true);
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
    private readonly InputAction m_Player_mouse;
    private readonly InputAction m_Player_up;
    private readonly InputAction m_Player_down;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @mouse => m_Wrapper.m_Player_mouse;
        public InputAction @up => m_Wrapper.m_Player_up;
        public InputAction @down => m_Wrapper.m_Player_down;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @mouse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @mouse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @mouse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @up.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUp;
                @up.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUp;
                @up.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUp;
                @down.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                @down.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                @down.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @mouse.started += instance.OnMouse;
                @mouse.performed += instance.OnMouse;
                @mouse.canceled += instance.OnMouse;
                @up.started += instance.OnUp;
                @up.performed += instance.OnUp;
                @up.canceled += instance.OnUp;
                @down.started += instance.OnDown;
                @down.performed += instance.OnDown;
                @down.canceled += instance.OnDown;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
}
