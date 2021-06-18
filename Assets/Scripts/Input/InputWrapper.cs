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
    [SerializeField] private PlayerInput control;

    #region "Action Map Switch Flags"
    [SerializeField] private ActionMapFlag playerTurnMain;
    [SerializeField] private ActionMapFlag playerTurnSelection;
    [SerializeField] private ActionMapFlag playerTurnExecution;
    [SerializeField] private ActionMapFlag enemyTurnMain;
    #endregion

    #region "Player Turn - Main Input Events(Fields)"
    //TODO: Static Events should be changed to non Statics Later
    [SerializeField] private UnityEvent<Vector2> playerTurnMainMovement;
    [SerializeField] private SharedEvent playerTurnMainInteract;
    [SerializeField] private SharedEvent playerTurnMainEndTurn;
    #endregion

    #region "Player Turn - Unit Action Selection Input Events(Fields)"
    [SerializeField] private SharedEvent ActionSelectionInteract;
    [SerializeField] private SharedEvent ActionSelectionCancel;
    #endregion

    #region "Player Turn - Unit Action Execution Input Events(Fields)"
    // TODO: Static Events should be changed to non Statics Later
    [SerializeField] private SharedMovementEvent ExecutionMovement;
    [SerializeField] private SharedEvent ExecutionInteract;
    [SerializeField] private SharedEvent ExecutionCancel;
    #endregion

    #region "AI Turn - Main Input Events(Fields)"
    [SerializeField] private SharedEvent EndAITurn;
    #endregion



    void Awake()
    {
        input = new TacticalStrategy();
        
    }

    void Update()
    {
        CheckAndChangeActionMaps();
    }

    private void CheckAndChangeActionMaps()
    {
        if (playerTurnMain.IsSet())
        {
            control.SwitchCurrentActionMap("Player Turn - Main");
        }
        else if (playerTurnSelection.IsSet())
        {
            control.SwitchCurrentActionMap("Player Turn - Unit Action Selection");
        }
        else if (playerTurnExecution.IsSet())
        {
            control.SwitchCurrentActionMap("Player Turn - Unit Action Execution");
        }
        else if (enemyTurnMain.IsSet())
        {
            control.SwitchCurrentActionMap("AI Turn - Main");
        }
    }

    #region "Player Turn - Main Methods"
    public void PlayerMainMovementWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            playerTurnMainMovement.Invoke(context.ReadValue<Vector2>());
        }
    }

    public void PlayerMainInteractWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            playerTurnMainInteract.Invoke();
        }
    }


    public void PlayerMainEndTurnWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            playerTurnMainEndTurn.Invoke();
        }

    }
    #endregion


    #region "Player Turn - Unit Action Selection Methods"

    public void ActionSelectionInteractWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ActionSelectionInteract.Invoke();
        }
    }


    public void ActionSelectionCancelWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ActionSelectionCancel.Invoke();
        }
    }
    #endregion


    #region "Player Turn - Unit Action Execution Methods"
    public void ExecutionMovementWrapper(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            ExecutionMovement.Invoke(context.ReadValue<Vector2>());
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
    }

}
