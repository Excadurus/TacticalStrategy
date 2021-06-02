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
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""EndTurn"",
                    ""type"": ""Button"",
                    ""id"": ""bb5c31d8-7df7-4132-9fa8-03209f168105"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
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
                }
            ]
        },
        {
            ""name"": ""UnitActionSelection"",
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
            ""name"": ""UnitActionExecution"",
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
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""786f778b-0e84-46ff-a32c-315365fdd14e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""ce51c721-4d2f-4703-bba8-0c166df395be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4725956b-1815-41d1-8d8b-c5fa58703c11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""0b18cdfd-b9a7-4424-8f73-30db6ec4fa68"",
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
                    ""name"": """",
                    ""id"": ""fbd053ed-4ddc-4406-a429-de1c68e3e1c8"",
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
                    ""id"": ""3b0b8899-dfa0-4d07-906c-ac680aa5c105"",
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
                    ""id"": ""0e0107ba-f924-4035-a9ad-91c3f18a5eeb"",
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
                    ""id"": ""020bc9e9-ab41-436f-9891-ba16c0f43834"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AITurnActions"",
            ""id"": ""e764dd5c-7a3c-4b64-8a76-7672f8ae14de"",
            ""actions"": [
                {
                    ""name"": ""EndAITurn"",
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
                    ""action"": ""EndAITurn"",
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
        m_FreeRoam_EndTurn = m_FreeRoam.FindAction("EndTurn", throwIfNotFound: true);
        // UnitActionSelection
        m_UnitActionSelection = asset.FindActionMap("UnitActionSelection", throwIfNotFound: true);
        m_UnitActionSelection_Interact = m_UnitActionSelection.FindAction("Interact", throwIfNotFound: true);
        m_UnitActionSelection_Cancel = m_UnitActionSelection.FindAction("Cancel", throwIfNotFound: true);
        // UnitActionExecution
        m_UnitActionExecution = asset.FindActionMap("UnitActionExecution", throwIfNotFound: true);
        m_UnitActionExecution_Interact = m_UnitActionExecution.FindAction("Interact", throwIfNotFound: true);
        m_UnitActionExecution_Cancel = m_UnitActionExecution.FindAction("Cancel", throwIfNotFound: true);
        m_UnitActionExecution_MoveUp = m_UnitActionExecution.FindAction("MoveUp", throwIfNotFound: true);
        m_UnitActionExecution_MoveDown = m_UnitActionExecution.FindAction("MoveDown", throwIfNotFound: true);
        m_UnitActionExecution_MoveLeft = m_UnitActionExecution.FindAction("MoveLeft", throwIfNotFound: true);
        m_UnitActionExecution_MoveRight = m_UnitActionExecution.FindAction("MoveRight", throwIfNotFound: true);
        // AITurnActions
        m_AITurnActions = asset.FindActionMap("AITurnActions", throwIfNotFound: true);
        m_AITurnActions_EndAITurn = m_AITurnActions.FindAction("EndAITurn", throwIfNotFound: true);
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
    private readonly InputAction m_FreeRoam_EndTurn;
    public struct FreeRoamActions
    {
        private @TacticalStrategy m_Wrapper;
        public FreeRoamActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_FreeRoam_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_FreeRoam_MoveDown;
        public InputAction @MoveLeft => m_Wrapper.m_FreeRoam_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_FreeRoam_MoveRight;
        public InputAction @Interact => m_Wrapper.m_FreeRoam_Interact;
        public InputAction @EndTurn => m_Wrapper.m_FreeRoam_EndTurn;
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
                @EndTurn.started -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnEndTurn;
                @EndTurn.performed -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnEndTurn;
                @EndTurn.canceled -= m_Wrapper.m_FreeRoamActionsCallbackInterface.OnEndTurn;
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
                @EndTurn.started += instance.OnEndTurn;
                @EndTurn.performed += instance.OnEndTurn;
                @EndTurn.canceled += instance.OnEndTurn;
            }
        }
    }
    public FreeRoamActions @FreeRoam => new FreeRoamActions(this);

    // UnitActionSelection
    private readonly InputActionMap m_UnitActionSelection;
    private IUnitActionSelectionActions m_UnitActionSelectionActionsCallbackInterface;
    private readonly InputAction m_UnitActionSelection_Interact;
    private readonly InputAction m_UnitActionSelection_Cancel;
    public struct UnitActionSelectionActions
    {
        private @TacticalStrategy m_Wrapper;
        public UnitActionSelectionActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_UnitActionSelection_Interact;
        public InputAction @Cancel => m_Wrapper.m_UnitActionSelection_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_UnitActionSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UnitActionSelectionActions set) { return set.Get(); }
        public void SetCallbacks(IUnitActionSelectionActions instance)
        {
            if (m_Wrapper.m_UnitActionSelectionActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_UnitActionSelectionActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_UnitActionSelectionActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_UnitActionSelectionActionsCallbackInterface.OnInteract;
                @Cancel.started -= m_Wrapper.m_UnitActionSelectionActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UnitActionSelectionActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UnitActionSelectionActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UnitActionSelectionActionsCallbackInterface = instance;
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
    public UnitActionSelectionActions @UnitActionSelection => new UnitActionSelectionActions(this);

    // UnitActionExecution
    private readonly InputActionMap m_UnitActionExecution;
    private IUnitActionExecutionActions m_UnitActionExecutionActionsCallbackInterface;
    private readonly InputAction m_UnitActionExecution_Interact;
    private readonly InputAction m_UnitActionExecution_Cancel;
    private readonly InputAction m_UnitActionExecution_MoveUp;
    private readonly InputAction m_UnitActionExecution_MoveDown;
    private readonly InputAction m_UnitActionExecution_MoveLeft;
    private readonly InputAction m_UnitActionExecution_MoveRight;
    public struct UnitActionExecutionActions
    {
        private @TacticalStrategy m_Wrapper;
        public UnitActionExecutionActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_UnitActionExecution_Interact;
        public InputAction @Cancel => m_Wrapper.m_UnitActionExecution_Cancel;
        public InputAction @MoveUp => m_Wrapper.m_UnitActionExecution_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_UnitActionExecution_MoveDown;
        public InputAction @MoveLeft => m_Wrapper.m_UnitActionExecution_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_UnitActionExecution_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_UnitActionExecution; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UnitActionExecutionActions set) { return set.Get(); }
        public void SetCallbacks(IUnitActionExecutionActions instance)
        {
            if (m_Wrapper.m_UnitActionExecutionActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnInteract;
                @Cancel.started -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnCancel;
                @MoveUp.started -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveDown;
                @MoveLeft.started -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_UnitActionExecutionActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_UnitActionExecutionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
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
            }
        }
    }
    public UnitActionExecutionActions @UnitActionExecution => new UnitActionExecutionActions(this);

    // AITurnActions
    private readonly InputActionMap m_AITurnActions;
    private IAITurnActionsActions m_AITurnActionsActionsCallbackInterface;
    private readonly InputAction m_AITurnActions_EndAITurn;
    public struct AITurnActionsActions
    {
        private @TacticalStrategy m_Wrapper;
        public AITurnActionsActions(@TacticalStrategy wrapper) { m_Wrapper = wrapper; }
        public InputAction @EndAITurn => m_Wrapper.m_AITurnActions_EndAITurn;
        public InputActionMap Get() { return m_Wrapper.m_AITurnActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AITurnActionsActions set) { return set.Get(); }
        public void SetCallbacks(IAITurnActionsActions instance)
        {
            if (m_Wrapper.m_AITurnActionsActionsCallbackInterface != null)
            {
                @EndAITurn.started -= m_Wrapper.m_AITurnActionsActionsCallbackInterface.OnEndAITurn;
                @EndAITurn.performed -= m_Wrapper.m_AITurnActionsActionsCallbackInterface.OnEndAITurn;
                @EndAITurn.canceled -= m_Wrapper.m_AITurnActionsActionsCallbackInterface.OnEndAITurn;
            }
            m_Wrapper.m_AITurnActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EndAITurn.started += instance.OnEndAITurn;
                @EndAITurn.performed += instance.OnEndAITurn;
                @EndAITurn.canceled += instance.OnEndAITurn;
            }
        }
    }
    public AITurnActionsActions @AITurnActions => new AITurnActionsActions(this);
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
        void OnEndTurn(InputAction.CallbackContext context);
    }
    public interface IUnitActionSelectionActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface IUnitActionExecutionActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
    public interface IAITurnActionsActions
    {
        void OnEndAITurn(InputAction.CallbackContext context);
    }
}
