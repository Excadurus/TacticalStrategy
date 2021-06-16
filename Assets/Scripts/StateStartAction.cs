using UnityEngine;
[CreateAssetMenu(fileName = "New Start Action", menuName = "State Machines/States/Actions/Start Actions", order = 1)]

public abstract class StateStartAction : ScriptableObject
{
    public abstract void Act();
}
