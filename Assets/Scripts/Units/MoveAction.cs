using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAction : UnitActions
{
    [SerializeField]private Path[] paths;
    private Cursor c;
    [SerializeField] Unit u;


    void Awake()
    {
        
    }

    void Start()
    {
        c = GameObject.Find("Cursor").GetComponent<Cursor>();
        Act();
    }


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
            u.tile = c.getTile();
            Destroy();
        }
    }

    protected override void MoveUp()
    {
      c.MoveUp();
    }

    protected override void MoveDown()
    {
        c.MoveDown();
    }

    protected override void MoveLeft()
    {
        c.MoveLeft();
    }

    protected override void MoveRight()
    {
        c.MoveRight();
    }
}
