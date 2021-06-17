using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New State", menuName = "State Machines/States/State", order = 1)]
public class State : ScriptableObject
{

    [SerializeField] public List<Transition> transitions;

    [SerializeField] private List<StateAction> enterActions;
    [SerializeField] private List<StateAction> updateActions;
    [SerializeField] private List<StateAction> exitActions;

    [SerializeField] private List<StateEventAction> stateEvents;


    public void Enter()
    {
        foreach(StateEventAction se in stateEvents)
        {
            se.AddEvent();
        }

        foreach(StateAction sa in enterActions)
        {
            sa.Act();
        }
    }

    public void Update()
    {
        foreach (StateAction ua in updateActions)
        {
            ua.Act();
        }
    }

    public void Exit()
    {
        foreach (StateEventAction se in stateEvents)
        {
            se.RemoveEvent();
        }

        foreach (StateAction ea in exitActions)
        {
            ea.Act();
        }
    }
}
