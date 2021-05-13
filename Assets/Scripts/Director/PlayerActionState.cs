using UnityEngine;

public class PlayerActionState : DirectorState
{

    public PlayerActionState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
    {
        InputWrapper.FreeRoamEndPlayerTurn += EndTurn;
    }

    public override void Start()
    {
    }

    public override void FixedUpdate()
    {
        
    }
    public override void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.A) && director.cursor.getTile().unit!=null && director.cursor.getTile().unit.IsActive())
        {

        }*/

        if (director.HasFinishedFinalTurn())
        {
            dsm.changeState(dsm.EndState);
            return;
        }
    }

    public void EndTurn()
    {
        dsm.changeState(dsm.AIState);
        return;
    }
    public override void Exit()
    {

        director.IncTurn();
    }
}
