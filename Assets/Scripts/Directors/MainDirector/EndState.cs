using UnityEditor;
using UnityEngine;

public class EndState : DirectorState
{
    public EndState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
    {
    }

    public override void Exit()
    {
        EditorApplication.isPlaying = false;
    }

    public override void FixedUpdate()
    {
    }

    public override void Start()
    {
    }

    public override void Update()
    {
    }
}
