//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/FPS Controller/FirstPersonMotion.inputactions
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

public partial class @FirstPersonMotion : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FirstPersonMotion()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FirstPersonMotion"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""85579bc7-007e-49bf-994d-d5c8c49571c9"",
            ""actions"": [
                {
                    ""name"": ""MouseX"",
                    ""type"": ""Value"",
                    ""id"": ""0b91059b-26eb-4c2d-88e6-b865b399e4d0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""Value"",
                    ""id"": ""18f24498-2b60-4c8f-bbe1-35a180951ac5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveXZ"",
                    ""type"": ""Value"",
                    ""id"": ""f9f59b33-d17f-411d-b826-db58e0718a17"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Button"",
                    ""id"": ""d49e9a08-db58-4825-991b-818a78966723"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ec9cc48-5d90-4722-a473-22110e9bfe0c"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2e48e62-779a-4a56-8cb9-9df343a589d4"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""de7a7542-e6ca-47c5-a41d-24fea09c1bd7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1ec3847b-e539-4a99-8565-f160232d6eac"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""65b43d2f-d08a-4a78-bce0-c4d3501e25ab"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d8eea3bd-7143-432e-bead-25eb5e944315"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""54d6e0da-f22b-45be-b182-83b2fd9fb6ae"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""568bcd4a-64cc-4376-8769-f3a7ed1cd19b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d3dee645-399f-4b53-8b4b-ba723a97367d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""81a22ecd-fc1e-40da-b978-e1d17dfd155a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_MouseX = m_Move.FindAction("MouseX", throwIfNotFound: true);
        m_Move_MouseY = m_Move.FindAction("MouseY", throwIfNotFound: true);
        m_Move_MoveXZ = m_Move.FindAction("MoveXZ", throwIfNotFound: true);
        m_Move_MoveY = m_Move.FindAction("MoveY", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_MouseX;
    private readonly InputAction m_Move_MouseY;
    private readonly InputAction m_Move_MoveXZ;
    private readonly InputAction m_Move_MoveY;
    public struct MoveActions
    {
        private @FirstPersonMotion m_Wrapper;
        public MoveActions(@FirstPersonMotion wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseX => m_Wrapper.m_Move_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Move_MouseY;
        public InputAction @MoveXZ => m_Wrapper.m_Move_MoveXZ;
        public InputAction @MoveY => m_Wrapper.m_Move_MoveY;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @MouseX.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMouseY;
                @MoveXZ.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveXZ;
                @MoveXZ.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveXZ;
                @MoveXZ.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveXZ;
                @MoveY.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveY;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @MoveXZ.started += instance.OnMoveXZ;
                @MoveXZ.performed += instance.OnMoveXZ;
                @MoveXZ.canceled += instance.OnMoveXZ;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnMoveXZ(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
    }
}
