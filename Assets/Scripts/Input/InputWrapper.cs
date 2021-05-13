using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputWrapper : MonoBehaviour
{
    //Input System
    private TacticalStrategy input;
    private PlayerInput control;

    #region "FreeRoam Input Events(Fields)"
    //TODO: Static Events should be changed to non Statics Later
    [SerializeField] UnityEvent FreeRoamMoveUpEvent;
    [SerializeField] UnityEvent FreeRoamMoveDownEvent;
    [SerializeField] UnityEvent FreeRoamMoveLeftEvent;
    [SerializeField] UnityEvent FreeRoamMoveRightEvent;
    public static event Action FreeRoamInteract;
    public static event Action FreeRoamEndPlayerTurn;
    #endregion

    #region "UnitActionExecution Events(Fields)"
    // TODO: Static Events should be changed to non Statics Later
    [SerializeField] private SharedEvent ExecutionMoveUpEvent;
    [SerializeField] private SharedEvent ExecutionMoveDownEvent;
    [SerializeField] private SharedEvent ExecutionMoveLeftEvent;
    [SerializeField] private SharedEvent ExecutionMoveRightEvent;
    [SerializeField] private SharedEvent ExecutionInteract;
    [SerializeField] private SharedEvent ExecutionCancel;
    #endregion

    #region "AITurnActions Events(Fields)"
    //TODO: Static Events should be changed to non Statics Later
    [SerializeField] public static event Action EndAITurn;
    #endregion



    public void Awake()
    {
        input = new TacticalStrategy();
        control = GetComponent<PlayerInput>();
        
    }


    #region "FreeRoam Methods"
    public void FreeRoamMoveUpWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            FreeRoamMoveUpEvent.Invoke();
        }
    }

    public void FreeRoamMoveDownWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            FreeRoamMoveDownEvent.Invoke();
        }
    }

    public void FreeRoamMoveLeftWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            FreeRoamMoveLeftEvent.Invoke();
        }
    }

    public void FreeRoamMoveRightWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            FreeRoamMoveRightEvent.Invoke();
        }
    }

    public void FreeRoamInteractWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            FreeRoamInteract.Invoke();
        }
    }


    public void EndPlayerTurnWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            FreeRoamEndPlayerTurn.Invoke();
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            control.SwitchCurrentActionMap("AITurnActions");
        }

    }
    #endregion



    #region "Execution Methods"
    public void ExecutionMoveUpWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ExecutionMoveUpEvent.Invoke();
        }
    }

    public void ExecutionMoveDownWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ExecutionMoveDownEvent.Invoke();
        }
    }

    public void ExecutionMoveLeftWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ExecutionMoveLeftEvent.Invoke();
        }
    }

    public void ExecutionMoveRightWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ExecutionMoveRightEvent.Invoke();
        }
    }

    public void ExecutionInteractWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ExecutionInteract.Invoke();
        }
    }


    public void ExecutionCancelWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ExecutionCancel.Invoke();
        }
    }
    #endregion

    public void EndAITurnWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            EndAITurn.Invoke();
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            control.SwitchCurrentActionMap("FreeRoam");
        }
    }

}
