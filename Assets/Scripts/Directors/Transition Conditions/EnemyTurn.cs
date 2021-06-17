using UnityEngine;
[CreateAssetMenu(fileName = "Enemy Turn Transition Condition", menuName = "State Machines/Transitions/Transition Condition/Enemy Turn", order = 2)]

public class EnemyTurn : TransitionCondition
{
    [SerializeField] private PlayerDirector playerDirector;
    public override bool IsSatisfied()
    {
        return !playerDirector.GetCurrentPlayer().IsPlayer();
    }
}
