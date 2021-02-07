using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected enum ActionState
    {
        CAN_MOVE, CAN_ATTACK, TURN_ENDED, ENEMY_TURN
    }

    [SerializeField] public Tile tile;
    [SerializeField] protected int hp = 20;
    [SerializeField] protected int dmg = 10;
    [SerializeField] protected int movementRange = 5;
    protected ActionState actionState = ActionState.ENEMY_TURN;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.hp == 0)
        {
            Destroy(this.gameObject);
        }

        transform.SetParent(tile.transform);
        transform.localPosition = new Vector3(0, 0.75f, 0);
        ChildUpdate();

    }

    public virtual void Attack(Unit target)
    {
        target.hp -= Mathf.Clamp(dmg, 0, target.hp);
    }

    //TODO: create this when tiles are implemented
    //public virtual int ReturnMovementCost()

    public abstract void ChildUpdate();
}
