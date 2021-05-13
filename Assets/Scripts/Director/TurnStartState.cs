using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnStartState : DirectorState
{
    public TurnStartState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
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
        director.IncTurn();
        faction.ActivateFactionUnits();

    }

    public override void Update()
    {
    }
}
