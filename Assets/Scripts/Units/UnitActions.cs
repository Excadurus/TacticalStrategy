using UnityEngine;


public abstract class UnitActions : ScriptableObject
{
    [HideInInspector]public bool isAvailable;
    protected Unit unit;


    [SerializeField] protected SharedEvent ExecutionInteract;
    [SerializeField] protected SharedEvent ExecutionMoveUpEvent;
    [SerializeField] protected SharedEvent ExecutionMoveDownEvent;
    [SerializeField] protected SharedEvent ExecutionMoveLeftEvent;
    [SerializeField] protected SharedEvent ExecutionMoveRightEvent;
    [SerializeField] protected SharedEvent ExecutionCancel;

    public void Act(Unit u)
    {
        unit = u;
        Initialize();
        ExecutionInteract.AddEvent(Interact);
        ExecutionMoveUpEvent.AddEvent(MoveUp);
        ExecutionMoveDownEvent.AddEvent(MoveDown);
        ExecutionMoveLeftEvent.AddEvent(MoveLeft);
        ExecutionMoveRightEvent.AddEvent(MoveRight);
        ExecutionCancel.AddEvent(Cancel);
    }

    protected abstract void Initialize();
    protected virtual void MoveUp() { }
    protected virtual void MoveDown() { }
    protected virtual void MoveLeft() { }
    protected virtual void MoveRight() { }
    protected abstract void Interact();
    protected abstract void Destroy();

    private void Cancel()
    {
        Destroy();
        ExecutionInteract.RemoveEvent(Interact);
        ExecutionMoveUpEvent.RemoveEvent(MoveUp);
        ExecutionMoveDownEvent.RemoveEvent(MoveDown);
        ExecutionMoveLeftEvent.RemoveEvent(MoveLeft);
        ExecutionMoveRightEvent.RemoveEvent(MoveRight);
        ExecutionCancel.RemoveEvent(Cancel);
    }

}
