using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Move Action", menuName = "Unit Actions/Move", order = 1)]
public class MoveAction : UnitActions
{
    private Path[] paths;
    [SerializeField]private Cursor c;


    protected override void Destroy()
    {
        foreach(Path p in paths){
            p.lastTile.ClearPath();
            p.lastTile.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    protected override void Initialize()
    {
        foreach (Path p in paths)
        {
            p.lastTile.setPath(p);
            p.lastTile.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    protected override void Interact()
    {
        if (c.getTile().CanMoveHere())
        {
            unit.tile = c.getTile();
            Cancel();
        }
    }

    protected override void Move(Vector2 direction)
    {
        c.Move(direction);
    }
}
