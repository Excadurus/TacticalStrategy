using UnityEngine;

public class Cursor : MonoBehaviour
{

    [SerializeField] public Tile startingTile;
    private Tile tile;
    [SerializeField] public GameBoard gameboard;
    private ICursorUser director;
    private ICursorUser owner;


    // Start is called before the first frame update
    void Start()
    {
        director = GameObject.Find("Director").GetComponent<Director>();
        tile = startingTile;
        owner = director;
        transform.SetParent(tile.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetParent(tile.transform);
        transform.localPosition = new Vector3(0, 0.5f, 0);

        owner = owner.ChangeUser(tile);
        if (owner.Yields())
        {
            owner = director;
            owner.Enable = true;
        }

        owner.Interact(tile);

        if (owner.Enable == true)
        {
            HandleCursorMovementInput();
        }

    }

    private void HandleCursorMovementInput()
    {
        //TODO: Handle this when you add UI Elements
        int gameboardColLen = GetBoardLength();
        int gameboardRowLen = GetBoardWidth();
        if (Input.GetKeyUp(KeyCode.RightArrow) && tile.col < gameboardColLen - 1)
        {
            SettingIndexOfCursorTile(0, 1);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) && tile.col > 0)
        {
            SettingIndexOfCursorTile(0, -1);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) && tile.row < gameboardRowLen - 1)
        {
            SettingIndexOfCursorTile(1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) && tile.row > 0)
        {
            SettingIndexOfCursorTile(-1, 0);
        }
    }

    private void SettingIndexOfCursorTile(int rowOffset, int colOffset)
    {
        int row = tile.row;
        int col = tile.col;
        tile = gameboard.rows[row + rowOffset].tiles[col + colOffset];
    }

    public int GetBoardLength()
    {
        return gameboard.rows[0].tiles.Length;
    }

    public int GetBoardWidth()
    {
        return gameboard.rows.Length;
    }

}
