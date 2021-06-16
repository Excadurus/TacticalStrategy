using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New State", menuName = "State Machines/States/State", order = 1)]
public abstract class State : ScriptableObject
{
    [SerializeField] public List<Transition> transitions;

    [SerializeField] private List<StateStartAction> startActions;
    [SerializeField] private List<StateUpdateAction> updateActions;
    [SerializeField] private List<StateEndAction> endActions;


    public void Start()
    {
        foreach(StateStartAction sa in startActions)
        {
            sa.Act();
        }
    }

    public void Update()
    {
        foreach (StateUpdateAction ua in updateActions)
        {
            ua.Act();
        }
    }

    public void End()
    {
        foreach (StateEndAction ea in endActions)
        {
            ea.Act();
        }
    }
}
