using UnityEngine;
[CreateAssetMenu(fileName = "New End Action", menuName = "State Machines/States/Actions/End Actions", order = 3)]

public abstract class StateEndAction : ScriptableObject
{
    public abstract void Act();
}
