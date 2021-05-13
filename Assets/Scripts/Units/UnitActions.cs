using UnityEngine;

public abstract class UnitActions : MonoBehaviour
{
    public bool isAvailable;

    public void Act()
    {
        Initialize();
        InputWrapper.ExecutionInteract += Interact;
        InputWrapper.ExecutionMoveUpEvent += MoveUp;
        InputWrapper.ExecutionMoveDownEvent += MoveDown;
        InputWrapper.ExecutionMoveLeftEvent += MoveLeft;
        InputWrapper.ExecutionMoveRightEvent += MoveRight;
        InputWrapper.ExecutionCancel += Cancel;
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
        InputWrapper.ExecutionInteract -= Interact;
        InputWrapper.ExecutionMoveUpEvent -= MoveUp;
        InputWrapper.ExecutionMoveDownEvent -= MoveDown;
        InputWrapper.ExecutionMoveLeftEvent -= MoveLeft;
        InputWrapper.ExecutionMoveRightEvent -= MoveRight;
        InputWrapper.ExecutionCancel -= Cancel;
    }

}
