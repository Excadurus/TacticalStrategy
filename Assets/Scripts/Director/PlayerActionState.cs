using UnityEngine;

public class PlayerActionState : DirectorState
{

    public PlayerActionState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
    {
        InputWrapper.FreeRoamEndPlayerTurn += EndTurn;
        InputWrapper.FreeRoamInteract += SelectUnit;
    }

    public override void Start()
    {
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
    }
    public void SelectUnit()
    {
        Unit u = director.cursor.getTile().unit;
        if(u != null)
        {
            u.GetComponent<Light>().enabled = true;
            director.selectedUnit = u;
            dsm.changeState(dsm.SelectedUnitState);
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
