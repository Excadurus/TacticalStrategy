using System;
using UnityEngine;
[CreateAssetMenu(fileName = "New Shared Movment Event", menuName = "Input/Shared Movment Event", order = 1)]

public class SharedMovementEvent : ScriptableObject
{
    private event Action<Vector2> Event;

    public void Invoke(Vector2 direction)
    {
        Event?.Invoke(direction);
    }

    public void AddEvent(Action<Vector2> a)
    {
        Event += a;
    }

    public void RemoveEvent(Action<Vector2> a)
    {
        Event -= a;
    }
}
