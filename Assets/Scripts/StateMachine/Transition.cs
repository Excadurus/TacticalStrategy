using System;
using UnityEngine;

[Serializable]
public class Transition
{
    [SerializeField] public TransitionCondition condition;
    [SerializeField] public State to;
}
