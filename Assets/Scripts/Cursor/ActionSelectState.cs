using UnityEngine;

public class ActionSelectState : CursorState
{
    public ActionSelectState(Cursor cursor, CursorStateMachine csm) : base(cursor, csm)
    {
    }

    public override void Exit()
    {

    }

    public override void FixedUpdate()
    {

    }

    public override void Start()
    {

    }

    public override void Update()
    {
        HandleActionSelectionInput();
        HandleDeselectInput();
    }

    private void HandleActionSelectionInput()
    {
        if (Input.GetKeyDown(KeyCode.C) && cursor.selectedUnit.CanMove())
        {
            cursor.selectedUnit.GetComponent<Light>().color = Color.green;
            csm.changeState(csm.ExecuteMovementState);
        }

        if (Input.GetKeyDown(KeyCode.D) && cursor.selectedUnit.IsActive())
        {
            cursor.selectedUnit.GetComponent<Light>().color = Color.red;
            csm.changeState(csm.ExecuteAttackState);
        }
    }

    private void HandleDeselectInput()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            cursor.selectedUnit.GetComponent<Light>().color = Color.blue;
            cursor.selectedUnit = null;
            csm.changeState(csm.FreeRoamState);
        }
    }
}
