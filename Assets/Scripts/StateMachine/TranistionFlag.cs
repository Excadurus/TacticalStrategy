using UnityEngine;
[CreateAssetMenu(fileName = "New Transition Flag", menuName = "State Machines/Transitions/Transition Flag", order = 1)]

public class TranistionFlag : ScriptableObject
{
    private bool isSet;

    void Awake()
    {
        isSet = false;    
    }

    public void Set()
    {
        isSet = true;
    }

    public bool IsSet()
    {
        bool returnValue = isSet;
        isSet = false;
        return returnValue;
    }

}
