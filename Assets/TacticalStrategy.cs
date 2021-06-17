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
            ""name"": ""Player Turn - Main"",
            ""id"": ""d05aee01-3890-41cb-86c4-54d6ee4410f0"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""3adb6575-132e-4ed3-b4be-62e49f1c1119"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""EndTurn"",
                    ""type"": ""Button"",
                    ""id"": ""bb5c31d8-7df7-4132-9fa8-03209f168105"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""b7870d10-eefe-4379-9a3c-807e6f326e7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
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
                },
                {
                    ""name"": """",
                    ""id"": ""b8bb725c-3ef8-4d12-bcd1-b2af3d635802"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""EndTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9f65ef2b-5609-40b6-8a8c-e928cfaca51d"",
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
                    ""id"": ""822fa13f-0260-4f29-85e7-81358fb767a4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f2988aa5-c46a-4d35-b6f8-c3b631c30308"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""71bd6604-3871-47d3-8780-f25d6f467980"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""deb0d278-4d5e-45c1-b492-148a46234bbd"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player Turn - Unit Action Selection"",
            ""id"": ""f3b0e704-534d-4691-8161-3d950062cbd0"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""949025c1-6011-46d6-9199-bfbc6cb61087"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""3627629d-015f-400a-abcd-ed26ed17e79d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11b93f17-ae65-4e2e-a559-9bb390475f0c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4edf86ec-da7f-4876-ac00-907dec8ef9e3"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Turn - Unit Action Execution"",
            ""id"": ""aaae626a-f4ea-4523-95c8-bd24a98d969c"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""53fa64e8-80bf-4c50-bfbd-8bccb253afa3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""12c8937d-50be-4393-946c-e69f3fbc002b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""0197e8f4-0c6f-4727-9db2-8ab04832ebe8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5df8c853-2499-475c-bb8b-f167fcc28b1c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9ef3873-1409-4d02-aa1f-3bb0aef17ff3"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""68b1545b-f00e-46a1-8737-db6614fc3045"",
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
                    ""id"": ""d3976f29-8265-4d69-85ac-9f736d5cf079"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""47f87f97-90e7-4b73-a7fb-3e409fc14f3f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f5c53e07-05cd-469f-8032-b7bb983547f9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""684bec13-cce7-470d-b0cd-697d0a2a3fd1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""AI Turn - Main"",
            ""id"": ""e764dd5c-7a3c-4b64-8a76-7672f8ae14de"",
            ""actions"": [
                {
                    ""name"": ""End Turn"",
                    ""type"": ""Button"",
                    ""id"": ""880f11ba-304d-4c06-a817-1d190424e36f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd1d87e5-4862-48cc-891f-a3518f9ecf97"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""End Turn"",
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
        // Player Turn - Main
        m_PlayerTurnMain = asset.FindActionMap("Player Turn - Main", throwIfNotFound: true);
        m_PlayerTurnMain_Interact = m_PlayerTurnMain.FindAction("Interact", throwIfNotFound: true);
        m_PlayerTurnMain_EndTurn = m_PlayerTurnMain.FindAction("EndTurn", throwIfNotFound: true);
        m_PlayerTurnMain_Movement = m_PlayerTurnMain.FindAction("Movement", throwIfNotFound: true);
        // Player Turn - Unit Action Selection
        m_PlayerTurnUnitActionSelection = asset.FindActionMap("Player Turn - Unit Action Selection", throwIfNotFound: true);
        m_PlayerTurnUnitActionSelection_Interact = m_PlayerTurnUnitActionSelection.FindAction("Interact", throwIfNotFound: true);
        m_PlayerTurnUnitActionSelection_Cancel = m_PlayerTurnUnitActionSelection.FindAction("Cancel", throwIfNotFound: true);
        // Player Turn - Unit Action Execution
        m_PlayerTurnUnitActionExecution = asset.FindActionMap("Player Turn - Unit Action Execution", throwIfNotFound: true);
        m_PlayerTurnUnitActionExecution_Interact = m_PlayerTurnUnitActionExecution.FindAction("Interact", throwIfNotFound: true);
        m_PlayerTurnUnitActionExecution_Cancel = m_PlayerTurnUnitActionExecution.FindAction("Cancel", throwIfNotFound: true);
        m_PlayerTurnUnitActionExecution_Movement = m_PlayerTurnUnitActionExecution.FindAction("Movement", throwIfNotFound: true);
        // AI Turn - Main
        m_AITurnMain = asset.FindActionMap("AI Turn - Main", throwIfNotFound: true);
        m_AITurnMain_EndTurn = m_AITurnMain.FindAction("End Turn", throwIfNotFound: true);
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

    // Player Turn - Main
    private readonly InputActionMap m_PlayerTurnMain;
    private IPlayerTurnMainActions m_PlayerTurnMainActionsCallbackInterface;
    private readonly InputAction m_PlayerTurnMain_Interact;
    private readonly InputAction m_PlayerTurnMain_EndTurn;
    private readonly InputAction m_PlayerTurnMain_Movement;
    public struct PlayerTurnMainActions
    {
        private @TacticalStrategy m_Wrapper;
        public PlayerTurnMainActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_PlayerTurnMain_Interact;
        public InputAction @EndTurn => m_Wrapper.m_PlayerTurnMain_EndTurn;
        public InputAction @Movement => m_Wrapper.m_PlayerTurnMain_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTurnMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTurnMainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTurnMainActions instance)
        {
            if (m_Wrapper.m_PlayerTurnMainActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnInteract;
                @EndTurn.started -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnEndTurn;
                @EndTurn.performed -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnEndTurn;
                @EndTurn.canceled -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnEndTurn;
                @Movement.started -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerTurnMainActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerTurnMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @EndTurn.started += instance.OnEndTurn;
                @EndTurn.performed += instance.OnEndTurn;
                @EndTurn.canceled += instance.OnEndTurn;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerTurnMainActions @PlayerTurnMain => new PlayerTurnMainActions(this);

    // Player Turn - Unit Action Selection
    private readonly InputActionMap m_PlayerTurnUnitActionSelection;
    private IPlayerTurnUnitActionSelectionActions m_PlayerTurnUnitActionSelectionActionsCallbackInterface;
    private readonly InputAction m_PlayerTurnUnitActionSelection_Interact;
    private readonly InputAction m_PlayerTurnUnitActionSelection_Cancel;
    public struct PlayerTurnUnitActionSelectionActions
    {
        private @TacticalStrategy m_Wrapper;
        public PlayerTurnUnitActionSelectionActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_PlayerTurnUnitActionSelection_Interact;
        public InputAction @Cancel => m_Wrapper.m_PlayerTurnUnitActionSelection_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTurnUnitActionSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTurnUnitActionSelectionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTurnUnitActionSelectionActions instance)
        {
            if (m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface.OnInteract;
                @Cancel.started -= m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_PlayerTurnUnitActionSelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public PlayerTurnUnitActionSelectionActions @PlayerTurnUnitActionSelection => new PlayerTurnUnitActionSelectionActions(this);

    // Player Turn - Unit Action Execution
    private readonly InputActionMap m_PlayerTurnUnitActionExecution;
    private IPlayerTurnUnitActionExecutionActions m_PlayerTurnUnitActionExecutionActionsCallbackInterface;
    private readonly InputAction m_PlayerTurnUnitActionExecution_Interact;
    private readonly InputAction m_PlayerTurnUnitActionExecution_Cancel;
    private readonly InputAction m_PlayerTurnUnitActionExecution_Movement;
    public struct PlayerTurnUnitActionExecutionActions
    {
        private @TacticalStrategy m_Wrapper;
        public PlayerTurnUnitActionExecutionActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_PlayerTurnUnitActionExecution_Interact;
        public InputAction @Cancel => m_Wrapper.m_PlayerTurnUnitActionExecution_Cancel;
        public InputAction @Movement => m_Wrapper.m_PlayerTurnUnitActionExecution_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTurnUnitActionExecution; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTurnUnitActionExecutionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTurnUnitActionExecutionActions instance)
        {
            if (m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnInteract;
                @Cancel.started -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnCancel;
                @Movement.started -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerTurnUnitActionExecutionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerTurnUnitActionExecutionActions @PlayerTurnUnitActionExecution => new PlayerTurnUnitActionExecutionActions(this);

    // AI Turn - Main
    private readonly InputActionMap m_AITurnMain;
    private IAITurnMainActions m_AITurnMainActionsCallbackInterface;
    private readonly InputAction m_AITurnMain_EndTurn;
    public struct AITurnMainActions
    {
        private @TacticalStrategy m_Wrapper;
        public AITurnMainActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @EndTurn => m_Wrapper.m_AITurnMain_EndTurn;
        public InputActionMap Get() { return m_Wrapper.m_AITurnMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AITurnMainActions set) { return set.Get(); }
        public void SetCallbacks(IAITurnMainActions instance)
        {
            if (m_Wrapper.m_AITurnMainActionsCallbackInterface != null)
            {
                @EndTurn.started -= m_Wrapper.m_AITurnMainActionsCallbackInterface.OnEndTurn;
                @EndTurn.performed -= m_Wrapper.m_AITurnMainActionsCallbackInterface.OnEndTurn;
                @EndTurn.canceled -= m_Wrapper.m_AITurnMainActionsCallbackInterface.OnEndTurn;
            }
            m_Wrapper.m_AITurnMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EndTurn.started += instance.OnEndTurn;
                @EndTurn.performed += instance.OnEndTurn;
                @EndTurn.canceled += instance.OnEndTurn;
            }
        }
    }
    public AITurnMainActions @AITurnMain => new AITurnMainActions(this);
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
    public interface IPlayerTurnMainActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnEndTurn(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IPlayerTurnUnitActionSelectionActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface IPlayerTurnUnitActionExecutionActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IAITurnMainActions
    {
        void OnEndTurn(InputAction.CallbackContext context);
    }
}
