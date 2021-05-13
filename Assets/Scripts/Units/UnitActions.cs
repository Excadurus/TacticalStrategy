using UnityEngine;

public abstract class UnitActions : MonoBehaviour
{
    public bool isAvailable;

    [SerializeField] SharedEvent ExecutionInteract;
    [SerializeField] SharedEvent ExecutionMoveUpEvent;
    [SerializeField] SharedEvent ExecutionMoveDownEvent;
    [SerializeField] SharedEvent ExecutionMoveLeftEvent;
    [SerializeField] SharedEvent ExecutionMoveRightEvent;
    [SerializeField] SharedEvent ExecutionCancel;

    public void Act()
    {
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
