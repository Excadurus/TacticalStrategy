using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New State Machine", menuName = "State Machines/State Machine", order = 0)]
public class StateMachine : ScriptableObject
{
    
    [SerializeField] public List<State> states;
    [SerializeField] public State startState;

    [SerializeField] public List<Transition> anyTransitions;

    private State currentState;

    void Awake()
    {
        currentState = startState;    
    }

    public void Tick()
    {
        CheckAnyTransitions();
        CheckCurrentStateTransitions();
        currentState.Update();
    }

    private void CheckAnyTransitions()
    {
        foreach(Transition t in anyTransitions)
        {
            if (t.condition.IsSatisfied())
            {
                ChangeState(t.to);
                break;
            }
        }
    }

    private void CheckCurrentStateTransitions()
    {
        foreach (Transition t in currentState.transitions)
        {
            if (t.condition.IsSatisfied())
            {
                ChangeState(t.to);
                break;
            }
        }
    }

    private void ChangeState(State s)
    {
        currentState.End();
        currentState = s;
        s.Start();
    }

}
