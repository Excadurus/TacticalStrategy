using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Always True Transition Condition", menuName = "State Machines/Transitions/Transition Condition/Always True", order = 1)]

public class AlwaysTrue : TransitionCondition
{
    public override bool IsSatisfied()
    {
        return true;
    }
}
