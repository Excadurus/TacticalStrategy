
using UnityEngine;

public class AIState : DirectorState
{
    public AIState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
    {
        InputWrapper.EndAITurn += FinishedTurn;
    }

    public override void Exit()
    {
    }

    public override void FixedUpdate()
    {
    }

    public override void Start()
    {
        Debug.Log("Enemy Turn!");

    }

    public override void Update()
    {
        if (director.HasFinishedFinalTurn())
        {
            dsm.changeState(dsm.EndState);
            return;
        }
        return;
    }

    public void FinishedTurn()
    {
        Debug.Log("AI has Finished Turn");
        dsm.changeState(dsm.PlayerActionState);
    }
}
