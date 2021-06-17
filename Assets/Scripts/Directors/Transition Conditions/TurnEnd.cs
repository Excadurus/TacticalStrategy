using UnityEngine;
[CreateAssetMenu(fileName = "Turn End Transition Condition", menuName = "State Machines/Transitions/Transition Condition/Turn End", order = 4)]

public class TurnEnd : TransitionCondition
{
    [SerializeField] private TranistionFlag endTurnFlag;
    public override bool IsSatisfied()
    {
        return endTurnFlag.IsSet();
    }
}
