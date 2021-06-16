public abstract class DirectorState
{
    protected Director director;
    protected Faction faction;
    protected DirectorStateMachine dsm;

    public DirectorState(Director director, DirectorStateMachine dsm, Faction faction){
        this.director = director;
        this.dsm = dsm;
        this.faction = faction;
    }

    public abstract void Start();

    public abstract void Update();

    public abstract void FixedUpdate();

    public abstract void Exit();
}
