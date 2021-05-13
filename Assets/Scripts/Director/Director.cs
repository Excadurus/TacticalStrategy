using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField] public Cursor cursor;
    [SerializeField] public InputWrapper inputWrapper;

    [SerializeField] private int maxTurnCount = 20;
    private int currentTurnCount = 0;

    //TODO: Handle Inputting Factions and their orders. affects DSM and Turn increment in States
    [SerializeField] List<Faction> players;
    public int currentPlayerIndex = 0;

    private DirectorStateMachine dsm;


    private void Awake()
    {
        dsm = new DirectorStateMachine(this, players[0], players[1]);
        dsm.Initialize();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dsm.currentState.Update();
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
