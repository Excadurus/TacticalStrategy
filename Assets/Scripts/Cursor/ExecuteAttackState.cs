
using UnityEngine;

public class ExecuteAttackState : CursorState
{
    public ExecuteAttackState(Cursor cursor, CursorStateMachine csm) : base(cursor, csm)
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
        HandleCursorMovementInput();
        HandleDestinationSelectionInput();
        HandleDeselectInput();
    }

    private void HandleCursorMovementInput()
    {
        //TODO: Handle this when you add UI Elements
        int gameboardColLen = cursor.getBoardLength();
        int gameboardRowLen = cursor.getBoardWidth();
        if (Input.GetKeyUp(KeyCode.RightArrow) && cursor.tile.col < gameboardColLen - 1)
        {
            SettingIndexOfCursorTile(0, 1);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) && cursor.tile.col > 0)
        {
            SettingIndexOfCursorTile(0, -1);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) && cursor.tile.row < gameboardRowLen - 1)
        {
            SettingIndexOfCursorTile(1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) && cursor.tile.row > 0)
        {
            SettingIndexOfCursorTile(-1, 0);
        }
    }

    private void SettingIndexOfCursorTile(int rowOffset, int colOffset)
    {
        int row = cursor.tile.row;
        int col = cursor.tile.col;
        cursor.tile = cursor.gameboard.rows[row + rowOffset].tiles[col + colOffset];
    }

    private void HandleDestinationSelectionInput()
    {
        if (Input.GetKeyDown(KeyCode.A) && cursor.tile.unit != null)
        {
            cursor.selectedUnit.GetComponent<Light>().enabled = false;
            cursor.selectedUnit.Attack(cursor.tile.unit);
            cursor.tile = cursor.selectedUnit.tile;
            cursor.selectedUnit.FinishTurn();
            cursor.selectedUnit = null;
            csm.changeState(csm.FreeRoamState);
        }
    }

    private void HandleDeselectInput()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            cursor.selectedUnit.GetComponent<Light>().color = Color.blue;
            cursor.tile = cursor.selectedUnit.tile;
            csm.changeState(csm.ActionSelectState);
        }
    }
}
