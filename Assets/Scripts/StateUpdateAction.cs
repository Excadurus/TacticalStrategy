using UnityEngine;
[CreateAssetMenu(fileName = "New Update Action", menuName = "State Machines/States/Actions/Update Actions", order = 2)]

public abstract class StateUpdateAction : ScriptableObject
{
    public abstract void Act();
}
