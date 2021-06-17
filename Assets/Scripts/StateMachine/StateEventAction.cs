using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateEventAction : ScriptableObject
{
    [SerializeField] public SharedEvent sharedEvent;

    protected abstract void Act();

    public void AddEvent()
    {
        sharedEvent.AddEvent(Act);
    }

    public void RemoveEvent()
    {
        sharedEvent.RemoveEvent(Act);
    }



}
