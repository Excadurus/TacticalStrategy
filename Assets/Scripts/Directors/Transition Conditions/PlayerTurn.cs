using UnityEngine;
[CreateAssetMenu(fileName = "Player Turn Transition Condition", menuName = "State Machines/Transitions/Transition Condition/Player Turn", order = 2)]

public class PlayerTurn : TransitionCondition
{
    [SerializeField] private PlayerDirector playerDirector;
    public override bool IsSatisfied()
    {
        return playerDirector.GetCurrentPlayer().IsPlayer();
    }
}
