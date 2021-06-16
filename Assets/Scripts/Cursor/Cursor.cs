using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Cursor : ScriptableObject
{
    //Make Private After you Create Pathfinder
    public GameBoard gameboard;
    private Tile baseTile;
    private Tile tile;

    private void OnEnable()
    {
    }

    public Tile getTile()
    {
        return tile;
    }


    public void MoveUp()
    {
        int row = tile.row;
        int col = tile.col;
        if (row == GetBoardLength() - 1) return;
        tile = gameboard.rows[row + 1].tiles[col];
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
        if (col == GetBoardWidth() - 1) return;
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

    public void Initialize(CursorHandler h)
    {
        gameboard= h.gameboard;
        baseTile = h.baseTile;
        tile = baseTile;
    }
}
