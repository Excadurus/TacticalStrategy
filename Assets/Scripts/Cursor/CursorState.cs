using UnityEngine;

public abstract class CursorState
{
    protected Cursor cursor;
    protected CursorStateMachine csm;
    
    protected CursorState(Cursor cursor, CursorStateMachine csm)
    {
        this.cursor = cursor;
        this.csm = csm;
    }
    public abstract void Start();

    public abstract void Update();

    public abstract void FixedUpdate();

    public abstract void Exit();
}

