using UnityEngine;

public class PlayerActionState : DirectorState
{

    public PlayerActionState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
    {
    }

    public override void Start()
    {
        faction.ActivateFactionUnits();
        director.cursor.enabled = true;
    }

    public override void FixedUpdate()
    {
        
    }
    public override void Update()
    {
        if (director.HasFinishedFinalTurn())
        {
            dsm.changeState(dsm.EndState);
            return;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            dsm.changeState(dsm.AIState);
            return;
        }
    }
    public override void Exit()
    {
        director.cursor.enabled = false;
        director.IncTurn();
    }
}
