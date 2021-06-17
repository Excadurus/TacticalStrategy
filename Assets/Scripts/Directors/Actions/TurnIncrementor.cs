using UnityEngine;
[CreateAssetMenu(fileName = "Turn Incrementor Action", menuName = "State Machines/States/Actions/Turn Incrementor", order = 1)]

public class TurnIncrementor : StateAction
{
    [SerializeField] TurnDirector turnDirector;
    public override void Act()
    {
        turnDirector.IncTurn();
    }
}
