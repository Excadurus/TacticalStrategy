using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class AttackAction : UnitActions
{
    private List<Tile> enemies;
    [SerializeField] private Cursor c;
    [SerializeField] private BattleDirector battleDirector;


    protected override void Destroy()
    {
        //TODO: Change when you decide what you want to do with ai
        foreach(Tile t in enemies)
        {
            t.transform.GetChild(1).gameObject.SetActive(false);
        }
    }

    protected override void Initialize()
    {
        //TODO: Use Pathfinder and Unit Range to find Enemies
        GameBoard g = c.gameboard;
        for(int i = 0; i < c.GetBoardWidth(); i++)
        {
            for(int j = 0; j < c.GetBoardLength(); j++)
            {
                if(g.rows[i].tiles[j].unit == null)
                {
                    continue;
                }
                Tile t = g.rows[i].tiles[j];
                enemies.Add(t);
                t.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }

    protected override void Interact()
    {
        if (enemies.Contains(c.getTile()))
        {
            //Use Battle Director
            battleDirector.ConductBattle(unit, c.getTile().unit);
            Cancel();
        }
    }

    protected override void MoveUp()
    {
    }

    protected override void MoveDown()
    {
    }

    protected override void MoveLeft()
    {
    }

    protected override void MoveRight()
    {
    }

}
