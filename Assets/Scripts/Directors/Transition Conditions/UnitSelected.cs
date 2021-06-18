using UnityEngine;

[CreateAssetMenu(fileName = "Unit Selected Transition Condition", menuName ="State Machines/Transitions/Transition Condition/Unit Selected",order = 5)]
public class UnitSelected : TransitionCondition
{
    [SerializeField] TranistionFlag unitSelectedFlag;

    public override bool IsSatisfied()
    {
        return unitSelectedFlag.IsSet();
    }
}
