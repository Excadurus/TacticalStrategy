using UnityEngine;

public class Cursor : MonoBehaviour
{
    enum CursorState
    {
        NOT_IN_CONTROL, FREE_ROAM, WAITING_FOR_COMMAND
    }



    [SerializeField] private Tile tile;
    [SerializeField] GameBoard gameboard;


    private CursorState state = CursorState.FREE_ROAM;
    private Unit selectedUnit;



    // Start is called before the first frame update
    void Start()
    {
        transform.SetParent(tile.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetParent(tile.transform);
        transform.localPosition = new Vector3(0, 0.5f, 0);
        MoveCursor();
        SelectUnit();
        MoveUnit();
        AttackWithUnit();
    }

    private void MoveCursor()
    {
        //TODO: Handle this when you add UI Elements
        //if (state == CursorState.WAITING_FOR_COMMAND)
        //{
        //    return;
        //}

        int gameboardColLen = gameboard.rows[0].tiles.Length;
        int gameboardRowLen = gameboard.rows.Length;
        if (Input.GetKey(KeyCode.RightArrow) && tile.col < gameboardColLen - 1)
        {
            int row = this.tile.row;
            int col = this.tile.col;
            this.tile = gameboard.rows[row].tiles[col + 1];
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && tile.col > 0)
        {
            int row = this.tile.row;
            int col = this.tile.col;
            this.tile = gameboard.rows[row].tiles[col - 1];
        }
        else if (Input.GetKey(KeyCode.UpArrow) && tile.row < gameboardRowLen - 1)
        {
            int row = this.tile.row;
            int col = this.tile.col;
            this.tile = gameboard.rows[row + 1].tiles[col];
        }
        else if (Input.GetKey(KeyCode.DownArrow) && tile.row > 0)
        {
            int row = this.tile.row;
            int col = this.tile.col;
            this.tile = gameboard.rows[row - 1].tiles[col];
        }
    }

    private void SelectUnit()
    {
        if (Input.GetKeyDown(KeyCode.A) && tile.unit != null && state == CursorState.FREE_ROAM && tile.unit.IsActive())
        {
            state = CursorState.WAITING_FOR_COMMAND;
            selectedUnit = tile.unit;
            selectedUnit.GetComponent<Light>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Z) && selectedUnit != null && state != CursorState.FREE_ROAM)
        {
            state = CursorState.FREE_ROAM;
            selectedUnit.GetComponent<Light>().enabled = false;
            tile = selectedUnit.tile;
            selectedUnit = null;
        }
    }

    private void MoveUnit()
    {
        if(Input.GetKeyDown(KeyCode.C) && selectedUnit != null && state == CursorState.WAITING_FOR_COMMAND && selectedUnit.CanMove())
        {
            state = CursorState.FREE_ROAM;
            selectedUnit.GetComponent<Light>().enabled = false;
            selectedUnit.tile = tile;
            selectedUnit.FinishMove();
            selectedUnit = null;
        }
    }

    private void AttackWithUnit()
    {
        if (Input.GetKeyDown(KeyCode.D) && selectedUnit != null && state == CursorState.WAITING_FOR_COMMAND && tile.unit != null && selectedUnit.IsActive())
        {
            state = CursorState.FREE_ROAM;
            selectedUnit.GetComponent<Light>().enabled = false;
            selectedUnit.Attack(tile.unit);
            tile = selectedUnit.tile;
            selectedUnit.FinishTurn();
            selectedUnit = null;
        }
    }
}
