using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Action Map Setter ", menuName = "State Machines/States/Actions/Action Map Setter", order = 6)]

public class ActionMapSetter : StateAction
{
    [SerializeField] ActionMapFlag flag;
    public override void Act()
    {
        flag.Set();
    }
}
