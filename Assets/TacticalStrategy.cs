// GENERATED AUTOMATICALLY FROM 'Assets/TacticalStrategy.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TacticalStrategy : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TacticalStrategy()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TacticalStrategy"",
    ""maps"": [
        {
            ""name"": ""FreeRoam"",
            ""id"": ""d05aee01-3890-41cb-86c4-54d6ee4410f0"",
            ""actions"": [
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""4b02008c-39b8-45be-b934-3bc26e6bb547"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""0d8b6151-9238-4e9e-bb28-3601cd3b034c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""7ed1d9ba-5fcb-4e9b-9adb-fd3fbe59050d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""85cc6b21-1a62-4086-a795-37092854aa37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""3adb6575-132e-4ed3-b4be-62e49f1c1119"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""77f7a91a-f1ad-4f75-96f7-30f1a959c7dc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f52bbfd6-c89b-4024-a315-e30fb007dd8d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97efa32c-87cb-4235-844f-f07ddd03aa38"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac2e2979-4918-4712-a4a2-207a248bda1d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f156bcd-1cf7-4ab3-88c3-78411330bdd8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ActionSelection"",
            ""id"": ""f3b0e704-534d-4691-8161-3d950062cbd0"",
            ""actions"": [
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""189999e5-e162-4f00-91b2-6a5aea2dbc12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d76885fe-2c34-484c-b40a-6bf6ef969689"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ActionTargetSelection"",
            ""id"": ""aaae626a-f4ea-4523-95c8-bd24a98d969c"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""53fa64e8-80bf-4c50-bfbd-8bccb253afa3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5df8c853-2499-475c-bb8b-f167fcc28b1c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // FreeRoam
        m_FreeRoam = asset.FindActionMap("FreeRoam", throwIfNotFound: true);
        m_FreeRoam_MoveUp = m_FreeRoam.FindAction("MoveUp", throwIfNotFound: true);
        m_FreeRoam_MoveDown = m_FreeRoam.FindAction("MoveDown", throwIfNotFound: true);
        m_FreeRoam_MoveLeft = m_FreeRoam.FindAction("MoveLeft", throwIfNotFound: true);
        m_FreeRoam_MoveRight = m_FreeRoam.FindAction("MoveRight", throwIfNotFound: true);
        m_FreeRoam_Interact = m_FreeRoam.FindAction("Interact", throwIfNotFound: true);
        // ActionSelection
        m_ActionSelection = asset.FindActionMap("ActionSelection", throwIfNotFound: true);
        m_ActionSelection_MoveUp = m_ActionSelection.FindAction("MoveUp", throwIfNotFound: true);
        // ActionTargetSelection
        m_ActionTargetSelection = asset.FindActionMap("ActionTargetSelection", throwIfNotFound: true);
        m_ActionTargetSelection_Newaction = m_ActionTargetSelection.FindAction("New action", throwIfNotFound: true);
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

    // FreeRoam
    private readonly InputActionMap m_FreeRoam;
    private IFreeRoamActions m_FreeRoamActionsCallbackInterface;
    private readonly InputAction m_FreeRoam_MoveUp;
    private readonly InputAction m_FreeRoam_MoveDown;
    private readonly InputAction m_FreeRoam_MoveLeft;
    private readonly InputAction m_FreeRoam_MoveRight;
    private readonly InputAction m_FreeRoam_Interact;
    public struct FreeRoamActions
    {
        private @TacticalStrategy m_Wrapper;
        public FreeRoamActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_FreeRoam_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_FreeRoam_MoveDown;
        public InputAction @MoveLeft => m_Wrapper.m_FreeRoam_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_FreeRoam_MoveRight;
        public InputAction @Interact => m_Wrapper.m_FreeRoam_Interact;
        public InputActionMap Get() { return m_Wrapper.m_FreeRoam; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FreeRoamActions set) { return set.Get(); }
        public void SetCallbacks(IFreeRoamActions instance)
        {
            if (m_Wrapper.m_FreeRoamActionsCallbackInterface != null)
            {
                @MoveUp.started -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveDown;
                @MoveLeft.started -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnMoveRight;
                @Interact.started -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_FreeRoamActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public FreeRoamActions @FreeRoam => new FreeRoamActions(this);

    // ActionSelection
    private readonly InputActionMap m_ActionSelection;
    private IActionSelectionActions m_ActionSelectionActionsCallbackInterface;
    private readonly InputAction m_ActionSelection_MoveUp;
    public struct ActionSelectionActions
    {
        private @TacticalStrategy m_Wrapper;
        public ActionSelectionActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_ActionSelection_MoveUp;
        public InputActionMap Get() { return m_Wrapper.m_ActionSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionSelectionActions set) { return set.Get(); }
        public void SetCallbacks(IActionSelectionActions instance)
        {
            if (m_Wrapper.m_ActionSelectionActionsCallbackInterface != null)
            {
                @MoveUp.started -= m_Wrapper.m_ActionSelectionActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_ActionSelectionActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_ActionSelectionActionsCallbackInterface.OnMoveUp;
            }
            m_Wrapper.m_ActionSelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
            }
        }
    }
    public ActionSelectionActions @ActionSelection => new ActionSelectionActions(this);

    // ActionTargetSelection
    private readonly InputActionMap m_ActionTargetSelection;
    private IActionTargetSelectionActions m_ActionTargetSelectionActionsCallbackInterface;
    private readonly InputAction m_ActionTargetSelection_Newaction;
    public struct ActionTargetSelectionActions
    {
        private @TacticalStrategy m_Wrapper;
        public ActionTargetSelectionActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_ActionTargetSelection_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_ActionTargetSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionTargetSelectionActions set) { return set.Get(); }
        public void SetCallbacks(IActionTargetSelectionActions instance)
        {
            if (m_Wrapper.m_ActionTargetSelectionActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_ActionTargetSelectionActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_ActionTargetSelectionActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_ActionTargetSelectionActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_ActionTargetSelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public ActionTargetSelectionActions @ActionTargetSelection => new ActionTargetSelectionActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IFreeRoamActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IActionSelectionActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
    }
    public interface IActionTargetSelectionActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
