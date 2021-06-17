using UnityEngine;
[CreateAssetMenu(fileName = "New Action Map Flag", menuName = "Input/Action Map Flag", order = 2)]

public class ActionMapFlag : ScriptableObject
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
