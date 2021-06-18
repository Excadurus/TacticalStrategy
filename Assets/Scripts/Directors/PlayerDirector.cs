using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Director", menuName = "Directors/Player Director", order = 2)]

public class PlayerDirector : ScriptableObject
{
    private List<Player> players;
    private int currentPlayer;

    public void SetPlayers(List<Player> players)
    {
        this.players = players;
    }

    void Awake()
    {
        currentPlayer = 0;
    }

    void OnDisable()
    {
        currentPlayer = 0;
    }


    public Player GetCurrentPlayer()
    {
        return players[currentPlayer];
    }

    public void SelectNextPlayer()
    {
        currentPlayer = (currentPlayer + 1) % players.Count;
    }

}
