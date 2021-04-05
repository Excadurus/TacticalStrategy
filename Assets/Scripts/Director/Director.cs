using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Director : MonoBehaviour
{
    //TODO: Give Cursor to Factions? Player Cursor, AI Cursor with different difficulties?
    [SerializeField] public Cursor cursor;

    [SerializeField] private int maxTurnCount = 20;
    private int currentTurnCount = 0;

    //TODO: Handle Inputting Factions and their orders. affects DSM and Turn increment in States
    [SerializeField] List<Faction> players;

    private DirectorStateMachine dsm;

    // Start is called before the first frame update
    void Start()
    {
        dsm = new DirectorStateMachine(this, players[0], players[1]);
        dsm.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            EditorApplication.isPlaying = false;
        }

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
