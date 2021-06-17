using System;
using UnityEngine;
[CreateAssetMenu(fileName = "New Shared Event", menuName = "Input/Shared Event", order = 0)]

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
