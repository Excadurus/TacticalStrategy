using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Transition Condition", menuName = "State Machines/Tranistions/Transition Condition", order = 1)]
public abstract class TransitionCondition : ScriptableObject
{
    public abstract bool IsSatisfied();
}
