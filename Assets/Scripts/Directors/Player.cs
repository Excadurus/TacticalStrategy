using UnityEngine;

public class Player
{
    private bool isPlayer;
    // Start is called before the first frame update

    public Player(bool isPlayer)
    {
        this.isPlayer = isPlayer;
    }


    public bool IsPlayer()
    {
        return isPlayer;
    }
}
