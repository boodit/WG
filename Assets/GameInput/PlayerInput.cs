//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/GameInput/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""86a934be-9918-4768-8f57-f20694e80499"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""14d3cc45-70a2-4cee-955c-ad0a6299d67d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""e018aa9e-de59-4604-8288-25727a6a6324"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8489bc36-f37a-4cdb-81d8-91912ddad510"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0bc94e7c-4552-48c8-ac7d-ccf926ae1811"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2394d58-171c-4de6-a476-184f97bb881f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ef43ba64-c947-4195-aa1b-97497f6de165"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fcc724f0-bb1d-48a7-a0b4-b0f2497e7937"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d9d81a03-c61f-4e29-8112-43aa4c1da1df"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0513a40a-50df-48ef-ad2a-6bc876ee9376"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa939d08-dc2c-4407-99cf-b878c32fbe95"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CastSystem"",
            ""id"": ""1af6a26e-bc06-4f82-bdc1-2cfd2f96a45a"",
            ""actions"": [
                {
                    ""name"": ""SecondarySpell"",
                    ""type"": ""Button"",
                    ""id"": ""25b6c259-823a-4fb9-8290-acb7a1d537dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimarySpell"",
                    ""type"": ""Button"",
                    ""id"": ""61baefa8-72d0-4fbb-9466-17c12124e872"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UltimateSpell"",
                    ""type"": ""Button"",
                    ""id"": ""49501837-1cac-4eb8-8e7f-fb2ad6be9da4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondSpell"",
                    ""type"": ""Button"",
                    ""id"": ""177b9f31-4136-402b-aca8-171de6cb85ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FirstSpell"",
                    ""type"": ""Button"",
                    ""id"": ""419bd390-4557-4839-ac91-4e78ba1813b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""130f621b-1a99-4874-ba13-6271e0107f38"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirstSpell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5aad4b50-b9f0-42b3-beb9-b290efd7bbe3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondSpell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8b59a00-581d-41af-ae84-55ce1ca29571"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UltimateSpell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cb683d1-d9e1-4378-b4eb-00715a58d778"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimarySpell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e409947-4c7b-470e-a02d-3eeb55cf461c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondarySpell"",
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
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        // CastSystem
        m_CastSystem = asset.FindActionMap("CastSystem", throwIfNotFound: true);
        m_CastSystem_SecondarySpell = m_CastSystem.FindAction("SecondarySpell", throwIfNotFound: true);
        m_CastSystem_PrimarySpell = m_CastSystem.FindAction("PrimarySpell", throwIfNotFound: true);
        m_CastSystem_UltimateSpell = m_CastSystem.FindAction("UltimateSpell", throwIfNotFound: true);
        m_CastSystem_SecondSpell = m_CastSystem.FindAction("SecondSpell", throwIfNotFound: true);
        m_CastSystem_FirstSpell = m_CastSystem.FindAction("FirstSpell", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // CastSystem
    private readonly InputActionMap m_CastSystem;
    private List<ICastSystemActions> m_CastSystemActionsCallbackInterfaces = new List<ICastSystemActions>();
    private readonly InputAction m_CastSystem_SecondarySpell;
    private readonly InputAction m_CastSystem_PrimarySpell;
    private readonly InputAction m_CastSystem_UltimateSpell;
    private readonly InputAction m_CastSystem_SecondSpell;
    private readonly InputAction m_CastSystem_FirstSpell;
    public struct CastSystemActions
    {
        private @PlayerInput m_Wrapper;
        public CastSystemActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SecondarySpell => m_Wrapper.m_CastSystem_SecondarySpell;
        public InputAction @PrimarySpell => m_Wrapper.m_CastSystem_PrimarySpell;
        public InputAction @UltimateSpell => m_Wrapper.m_CastSystem_UltimateSpell;
        public InputAction @SecondSpell => m_Wrapper.m_CastSystem_SecondSpell;
        public InputAction @FirstSpell => m_Wrapper.m_CastSystem_FirstSpell;
        public InputActionMap Get() { return m_Wrapper.m_CastSystem; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CastSystemActions set) { return set.Get(); }
        public void AddCallbacks(ICastSystemActions instance)
        {
            if (instance == null || m_Wrapper.m_CastSystemActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CastSystemActionsCallbackInterfaces.Add(instance);
            @SecondarySpell.started += instance.OnSecondarySpell;
            @SecondarySpell.performed += instance.OnSecondarySpell;
            @SecondarySpell.canceled += instance.OnSecondarySpell;
            @PrimarySpell.started += instance.OnPrimarySpell;
            @PrimarySpell.performed += instance.OnPrimarySpell;
            @PrimarySpell.canceled += instance.OnPrimarySpell;
            @UltimateSpell.started += instance.OnUltimateSpell;
            @UltimateSpell.performed += instance.OnUltimateSpell;
            @UltimateSpell.canceled += instance.OnUltimateSpell;
            @SecondSpell.started += instance.OnSecondSpell;
            @SecondSpell.performed += instance.OnSecondSpell;
            @SecondSpell.canceled += instance.OnSecondSpell;
            @FirstSpell.started += instance.OnFirstSpell;
            @FirstSpell.performed += instance.OnFirstSpell;
            @FirstSpell.canceled += instance.OnFirstSpell;
        }

        private void UnregisterCallbacks(ICastSystemActions instance)
        {
            @SecondarySpell.started -= instance.OnSecondarySpell;
            @SecondarySpell.performed -= instance.OnSecondarySpell;
            @SecondarySpell.canceled -= instance.OnSecondarySpell;
            @PrimarySpell.started -= instance.OnPrimarySpell;
            @PrimarySpell.performed -= instance.OnPrimarySpell;
            @PrimarySpell.canceled -= instance.OnPrimarySpell;
            @UltimateSpell.started -= instance.OnUltimateSpell;
            @UltimateSpell.performed -= instance.OnUltimateSpell;
            @UltimateSpell.canceled -= instance.OnUltimateSpell;
            @SecondSpell.started -= instance.OnSecondSpell;
            @SecondSpell.performed -= instance.OnSecondSpell;
            @SecondSpell.canceled -= instance.OnSecondSpell;
            @FirstSpell.started -= instance.OnFirstSpell;
            @FirstSpell.performed -= instance.OnFirstSpell;
            @FirstSpell.canceled -= instance.OnFirstSpell;
        }

        public void RemoveCallbacks(ICastSystemActions instance)
        {
            if (m_Wrapper.m_CastSystemActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICastSystemActions instance)
        {
            foreach (var item in m_Wrapper.m_CastSystemActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CastSystemActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CastSystemActions @CastSystem => new CastSystemActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICastSystemActions
    {
        void OnSecondarySpell(InputAction.CallbackContext context);
        void OnPrimarySpell(InputAction.CallbackContext context);
        void OnUltimateSpell(InputAction.CallbackContext context);
        void OnSecondSpell(InputAction.CallbackContext context);
        void OnFirstSpell(InputAction.CallbackContext context);
    }
}
