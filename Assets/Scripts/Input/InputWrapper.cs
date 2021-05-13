using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputWrapper : MonoBehaviour
{
    TacticalStrategy input;
    PlayerInput control;

    [SerializeField] UnityEvent MoveUpEvent;
    [SerializeField] UnityEvent MoveDownEvent;
    [SerializeField] UnityEvent MoveLeftEvent;
    [SerializeField] UnityEvent MoveRightEvent;

    [SerializeField] public static event Action Interact;
    [SerializeField] public static event Action EndPlayerTurn;
    [SerializeField] public static event Action EndAITurn;




    public void Awake()
    {
        input = new TacticalStrategy();
        control = GetComponent<PlayerInput>();
        
    }
    public void MoveUpWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            MoveUpEvent.Invoke();
        }
    }

    public void MoveDownWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            MoveDownEvent.Invoke();
        }
    }

    public void MoveLeftWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            MoveLeftEvent.Invoke();
        }
    }

    public void MoveRightWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            MoveRightEvent.Invoke();
        }
    }


    public void EndPlayerTurnWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            EndPlayerTurn.Invoke();
        }
        if (context.phase == InputActionPhase.Canceled)
        {
            control.SwitchCurrentActionMap("AITurnActions");
        }

    }

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
