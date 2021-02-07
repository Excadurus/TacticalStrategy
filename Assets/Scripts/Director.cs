using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    private enum GameState
    {
        TURN_START, CURSOR_ACTION, TURN_END, GAME_END
    }

    //TODO: Add a Player Class and handle turns depending on that class
    private enum Turn
    {
        PLAYER, ENEMY
    }

    [SerializeField] Cursor cursor;
    [SerializeField] private int maxTurnCount = 20;
    private int currentTurnCount = 1;

    private GameState gameState = GameState.TURN_START;
    private Turn turn = Turn.PLAYER;

    [SerializeField] private Unit[] AllyUnits;
    [SerializeField] private Unit[] EnemyUnits;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            gameState = GameState.GAME_END;
        }

        if (gameState == GameState.TURN_START)
        {
            Unit[] unitToBeChanged = (turn == Turn.PLAYER) ? AllyUnits : EnemyUnits;
            foreach (Unit u in unitToBeChanged)
            {
                u.ActivateUnit();
            }
            gameState = GameState.CURSOR_ACTION;
            if (turn == Turn.PLAYER)
            {
                cursor.enabled = true;
            }
            if (turn == Turn.ENEMY)
            {
                print("Enemy Turn");
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameState = GameState.TURN_END;
        }

        if (gameState == GameState.TURN_END)
        {
            if (turn == Turn.PLAYER)
            {
                cursor.enabled = false;
            }

            turn = (turn == Turn.PLAYER) ? Turn.ENEMY : Turn.PLAYER;
            gameState = GameState.TURN_START;

        }

        if (gameState == GameState.GAME_END)
        {
            Application.Quit();
        }

    }
}
