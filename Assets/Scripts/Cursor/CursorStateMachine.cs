using UnityEngine;

public class CursorStateMachine
{
    private Cursor cursor;
    public CursorState FreeRoamState { get; set;}
    public CursorState ActionSelectState { get; set; }
    public CursorState ExecuteMovementState { get; set; }
    public CursorState ExecuteAttackState { get; set; }


    public CursorState currentState;

    public CursorStateMachine(Cursor cursor)
    {
        this.cursor = cursor;

        FreeRoamState = new FreeRoamState(cursor, this);
        ActionSelectState = new ActionSelectState(cursor, this);
        ExecuteMovementState = new ExecuteMovementState(cursor, this);
        ExecuteAttackState = new ExecuteAttackState(cursor, this);
        //TODO: Create other States
    }
    public void Initialize()
    {
        currentState = FreeRoamState;
        FreeRoamState.Start();
    }

    public void changeState(CursorState newState)
    {
        currentState.Exit();
        currentState = newState;
        newState.Start();
    }

}
