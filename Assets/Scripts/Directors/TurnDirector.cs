using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Turn Director", menuName = "Directors/Turn Director", order = 1)]

public class TurnDirector : ScriptableObject
{
    private int maxTurnCount;
    private int currentTurnCount;


    private void Awake()
    {
        maxTurnCount = 30; //Default Value
        currentTurnCount = 0;
    }

    void OnDisable()
    {
        maxTurnCount = 30; //Default Value
        currentTurnCount = 0;
    }

    public void SetMaxTurns(int n)
    {
        maxTurnCount = n;
    }

    public void IncTurn()
    {
        currentTurnCount++;
    }

    public bool HasFinishedFinalTurn()
    {
        return currentTurnCount == maxTurnCount;
    }
}
