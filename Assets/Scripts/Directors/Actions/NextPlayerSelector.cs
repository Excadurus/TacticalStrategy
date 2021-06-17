using UnityEngine;
[CreateAssetMenu(fileName = "Next Player Selector Action", menuName = "State Machines/States/Actions/Next Player Selector", order = 5)]

public class NextPlayerSelector : StateAction
{
    [SerializeField] PlayerDirector playerDirector;
    public override void Act()
    {
        playerDirector.SelectNextPlayer();
    }
}
