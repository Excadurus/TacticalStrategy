using UnityEngine;


public abstract class UnitActions : ScriptableObject
{
    //[HideInInspector]public bool isAvailable; TODO:
    protected Unit unit;


    [SerializeField] protected SharedEvent ExecutionInteract;
    [SerializeField] protected SharedMovementEvent ExecutionMovementEvent;
    [SerializeField] protected SharedEvent ExecutionCancel;

    public void Act(Unit u)
    {
        unit = u;
        Initialize();
        ExecutionInteract.AddEvent(Interact);
        ExecutionMovementEvent.AddEvent(Move);
        ExecutionCancel.AddEvent(Cancel);
    }

    protected abstract void Initialize();
    protected virtual void Move(Vector2 direction) { }
    protected abstract void Interact();
    protected abstract void Destroy();

    protected void Cancel()
    {
        Destroy();
        ExecutionInteract.RemoveEvent(Interact);
        ExecutionMovementEvent.RemoveEvent(Move);
        ExecutionCancel.RemoveEvent(Cancel);
    }

}
