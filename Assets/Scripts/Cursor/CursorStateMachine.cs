using UnityEngine;

public class CursorStateMachine
{
    private Cursor cursor;
    private CursorState PlayerActionState { get; set;}
    private CursorState AIActionState { get; set; }

    private CursorState currentState;

    public CursorStateMachine(Cursor cursor)
    {
        this.cursor = cursor;
        //TODO: Create other States
    }
    public void Initialize()
    {
        currentState = PlayerActionState;
        PlayerActionState.Start();
    }

    public void changeState(CursorState newState)
    {
        currentState.Exit();
        currentState = newState;
        newState.Start();
    }

}
