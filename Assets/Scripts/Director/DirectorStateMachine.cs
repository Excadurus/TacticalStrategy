
public class DirectorStateMachine
{
    public DirectorState PlayerActionState { get; set; }
    public DirectorState AIState { get; set; }
    //TODO: Change to a list to cover multiple factions
    public DirectorState EndState { get; set; }

    public DirectorState TurnStartState { get; set; }



    //TODO: Change to a list to cover multiple Factions

    public DirectorState currentState;
       
    public DirectorStateMachine(Director director, Faction playerFaction, Faction enemyFaction)
    {
        PlayerActionState = new PlayerActionState(director, this, playerFaction);
        AIState = new AIState(director, this, enemyFaction);
        EndState = new EndState(director, this, null);
        TurnStartState = new TurnStartState(director, this, null);
    }
    public void Initialize()
    {
        currentState = PlayerActionState;
        PlayerActionState.Start();
    }

    public void changeState(DirectorState newState)
    {
        currentState.Exit();
        currentState = newState;
        newState.Start();
    }
}
