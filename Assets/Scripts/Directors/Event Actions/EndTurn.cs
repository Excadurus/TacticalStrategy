using UnityEngine;
[CreateAssetMenu(fileName = "New End Turn State Event", menuName = "State Machines/States/Event Actions/End Turn", order = 1)]

public class EndTurn : StateEventAction
{
    [SerializeField] TranistionFlag turnEndFlag;
    protected override void Act()
    {
        turnEndFlag.Set();
    }
}
