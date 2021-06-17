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


    public Tile getTile()
    {
        return tile;
    }


    public void Move(Vector2 direction)
    {
        int row = tile.row;
        int col = tile.col;

        
        row = row + Mathf.CeilToInt(direction.y);
        if (row < 0) row = 0;
        if (row >= GetBoardWidth()) row = GetBoardWidth() - 1;

        col = col + Mathf.CeilToInt(direction.x);
        if (col < 0) col = 0;
        if (col >= GetBoardLength()) col = GetBoardLength() - 1;

        tile = gameboard.rows[row].tiles[col];
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
