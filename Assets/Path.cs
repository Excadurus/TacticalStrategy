using UnityEngine;
using System;
using System.Collections.Generic;
[Serializable]
public class Path
{
    public List<Tile> path;
    public Tile startingTile;
    public Tile lastTile;

    public Path()
    {
        path = new List<Tile>();
    }

    public Path(List<Tile> path)
    {
        this.path = path;
    }

    public void addToPath(Tile t)
    {
        //consider preventing random tiles from being added
        path.Add(t);
        lastTile = t;
    }


    public override bool Equals(object obj)
    {
        return obj is Path path &&
               EqualityComparer<Tile>.Default.Equals(startingTile, path.startingTile) &&
               EqualityComparer<Tile>.Default.Equals(lastTile, path.lastTile);
    }





}
