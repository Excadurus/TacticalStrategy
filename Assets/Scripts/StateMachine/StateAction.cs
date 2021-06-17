using UnityEngine;
[CreateAssetMenu(fileName = "New State Action", menuName = "State Machines/States/Actions", order = 1)]

public abstract class StateAction : ScriptableObject
{
    public abstract void Act();
}
