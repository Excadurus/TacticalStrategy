using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Action Selection Canceled Transition Condition",menuName ="State Machines/Transitions/Transition Condition/Action Selection Canceled",order = 6)]
public class ActionSelectionCanceled : TransitionCondition
{
    [SerializeField] TranistionFlag actionSelectionCanceledFlag;
    public override bool IsSatisfied()
    {
        return actionSelectionCanceledFlag.IsSet();
    }
}
