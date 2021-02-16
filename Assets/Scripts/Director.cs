using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    private enum GameState
    {
        TURN_START, CURSOR_ACTION, TURN_END, GAME_END
    }

    [SerializeField] Cursor cursor;
    [SerializeField] private int maxTurnCount = 20;
    private int currentTurnCount = 1;

    private GameState gameState = GameState.TURN_START;
    [SerializeField] List<Faction> players;
    private int playerTurnIndicator = 0;

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

            players[playerTurnIndicator].ActivateFactionUnits();

            gameState = GameState.CURSOR_ACTION;
            if (playerTurnIndicator == 0)
            {
                cursor.enabled = true;
            }
            if (playerTurnIndicator == 1)
            {
                print("Enemy Turn");
                gameState = GameState.TURN_END;
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameState = GameState.TURN_END;
        }

        if (gameState == GameState.TURN_END)
        {
            cursor.enabled = false;
            playerTurnIndicator = (playerTurnIndicator + 1) % players.Count;
            gameState = GameState.TURN_START;

        }

        if (gameState == GameState.GAME_END)
        {
            Application.Quit();
        }

    }
}
