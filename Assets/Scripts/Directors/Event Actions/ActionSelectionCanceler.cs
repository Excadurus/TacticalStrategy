using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Action Selection Canceler Event",menuName = "State Machines/States/Event Actions/Action Selection Canceler")]
public class ActionSelectionCanceler : StateEventAction
{
    [SerializeField] TranistionFlag actionSelectionCanceledFlag;
    [SerializeField] ActionDirector actionDirector;
    protected override void Act()
    {
        actionSelectionCanceledFlag.Set();
        actionDirector.GetActiveUnit().GetComponentInChildren<Light>().enabled = false;
        actionDirector.ClearActiveUnit();
    }

}
