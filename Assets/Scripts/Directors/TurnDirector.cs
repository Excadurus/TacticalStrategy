using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class TurnDirector : ScriptableObject
{
    private int maxTurnCount;
    private int currentTurnCount;


    private void Awake()
    {
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
