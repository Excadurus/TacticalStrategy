using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorMonoBehaviour : MonoBehaviour
{
    [SerializeField] private StateMachine directorStateMachine;

    [SerializeField] private Director director;
    [SerializeField] private PlayerDirector playerDirector;
    [SerializeField] private TurnDirector turnDirector;
  


    //TODO: Replace these with Initialization code

    [SerializeField] int maxTurnCount;

    // Start is called before the first frame update
    void Start()
    {
        List<Player> players = new List<Player>();
        players.Add(new Player(false));
        players.Add(new Player(true));

        playerDirector.SetPlayers(players);
        turnDirector.SetMaxTurns(maxTurnCount);

        directorStateMachine.start();


    }

    // Update is called once per frame
    void Update()
    {
        directorStateMachine.Tick();
    }
}
