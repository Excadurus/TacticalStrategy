using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputWrapper : MonoBehaviour
{
    TacticalStrategy input;

    [SerializeField] UnityEvent MoveUpEvent;
    [SerializeField] UnityEvent MoveDownEvent;
    [SerializeField] UnityEvent MoveLeftEvent;
    [SerializeField] UnityEvent MoveRightEvent;


    public void Awake()
    {
        input = new TacticalStrategy();
        
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




}
