using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Finisher Action", menuName = "State Machines/States/Actions/Finish Game", order = 6)]

public class GameFinisher : StateAction
{
    public override void Act()
    {
        EditorApplication.isPlaying = false;
    }
}
