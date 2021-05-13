using UnityEngine;

public class Cursor : MonoBehaviour
{

    [SerializeField] public Tile baseTile;
    private Tile tile;
    [SerializeField] public GameBoard gameboard;



    // Start is called before the first frame update
    void Start()
    {
        tile = baseTile;
        transform.SetParent(tile.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetParent(tile.transform);
        transform.localPosition = new Vector3(0, 0.5f, 0);
    }

    private void OnEnable()
    {
        tile = baseTile;
        transform.SetParent(tile.transform);
    }

    private void OnDisable()
    {
        baseTile = tile;
    }

    public Tile getTile()
    {
        return tile;
    }


    public void MoveUp()
    {
        int row = tile.row;
        int col = tile.col;
        if (row == GetBoardLength()-1) return;
        tile = gameboard.rows[row + 1].tiles[col];
        Debug.Log("pressed");
    }

    public void MoveDown()
    {
        int row = tile.row;
        int col = tile.col;
        if (row == 0) return;
        tile = gameboard.rows[row - 1].tiles[col];
    }

    public void MoveRight()
    {
        int row = tile.row;
        int col = tile.col;
        if (col == GetBoardWidth()-1) return;
        tile = gameboard.rows[row].tiles[col + 1];
    }

    public void MoveLeft()
    {
        int row = tile.row;
        int col = tile.col;
        if (col == 0) return;
        tile = gameboard.rows[row].tiles[col - 1];
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
