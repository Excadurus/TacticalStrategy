using UnityEngine;

public abstract class CursorState
{
    private Cursor cursor;
    private CursorStateMachine csm;

    public abstract void Start();

    public abstract void Update();

    public abstract void FixedUpdate();

    public abstract void Exit();
}

