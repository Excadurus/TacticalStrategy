
using UnityEngine;

public class AIState : DirectorState
{
    public AIState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
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

    }

    public override void Update()
    {
        if (director.HasFinishedFinalTurn())
        {
            dsm.changeState(dsm.EndState);
            return;
        }
        Debug.Log("Enemy Turn!");
        dsm.changeState(dsm.PlayerActionState);
        return;
    }
}
