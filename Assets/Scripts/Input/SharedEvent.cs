using System;
using UnityEngine;
[CreateAssetMenu]

public class SharedEvent : ScriptableObject
{
    private event Action Event;

    public void Invoke()
    {
        Event?.Invoke();
    }

    public void AddEvent(Action a)
    {
        Event += a;
    }

    public void RemoveEvent(Action a)
    {
        Event -= a;
    }

}
