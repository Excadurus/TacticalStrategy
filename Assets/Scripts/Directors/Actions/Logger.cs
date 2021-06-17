using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Logger Action", menuName = "State Machines/States/Actions/Logger", order = 4)]

public class Logger : StateAction
{
    [SerializeField] string logMessage;
    public override void Act()
    {
        Debug.Log(logMessage);
    }
}
