using UnityEngine;

public class FreeRoamState : CursorState
{
    public FreeRoamState(Cursor cursor, CursorStateMachine csm) : base(cursor, csm)
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
        HandleUnitSelectionInput();
    }

    private void HandleCursorMovementInput()
    {
        //TODO: Handle this when you add UI Elements
        int gameboardColLen = cursor.getBoardLength();
        int gameboardRowLen = cursor.getBoardWidth();
        if (Input.GetKeyUp(KeyCode.RightArrow) && cursor.tile.col < gameboardColLen - 1)
        {
            SettingIndexOfCursorTile(0,1);
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

    private void HandleUnitSelectionInput()
    {
        if (Input.GetKeyDown(KeyCode.A) && cursor.tile.unit != null && cursor.tile.unit.IsActive())
        {
            cursor.selectedUnit = cursor.tile.unit;
            cursor.selectedUnit.GetComponent<Light>().color = Color.blue;
            cursor.selectedUnit.GetComponent<Light>().enabled = true;
            csm.changeState(csm.ActionSelectState);
        }

    }
}
