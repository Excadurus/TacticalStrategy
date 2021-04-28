using UnityEngine;

public class Unit : MonoBehaviour, ICursorUser
{
    protected enum ActionState
    {
        CAN_MOVE, CAN_ATTACK, TURN_ENDED, ENEMY_TURN
    }

    [SerializeField] public Tile tile;
    [SerializeField] int hp = 20;
    [SerializeField] int dmg = 10;
    [SerializeField] int movementRange = 5;
    protected ActionState actionState = ActionState.ENEMY_TURN;

    public bool Enable {get; set;}


    // Start is called before the first frame update
    void Start()
    {
        Enable = true;
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

    }

    public virtual void Attack(Unit target)
    {
        target.hp -= Mathf.Clamp(dmg, 0, target.hp);
    }

    //TODO: create this when tiles are implemented
    //public virtual int ReturnMovementCost()


    public void ActivateUnit()
    {
        actionState = ActionState.CAN_MOVE;
    }

    public void FinishMove()
    {
        actionState = ActionState.CAN_ATTACK;
    }

    public void FinishTurn()
    {
        actionState = ActionState.TURN_ENDED;
    }

    public bool IsActive()
    {
        return actionState == ActionState.CAN_ATTACK || actionState == ActionState.CAN_MOVE;
    }

    public bool CanMove()
    {
        return actionState == ActionState.CAN_MOVE;
    }

    public bool CanAttack()
    {
        return actionState == ActionState.CAN_ATTACK;
    }

    public void Interact(Tile t)
    {
        if (Input.GetKeyDown(KeyCode.D) && IsActive() && t.unit != null)
        {
            Attack(t.unit);
            FinishTurn();
        }

        if (Input.GetKeyUp(KeyCode.C) && CanMove())
        {
            tile = t;
            FinishMove();
        }
    }

    public bool Yields()
    {
        if (Input.GetKeyDown(KeyCode.Z) || !IsActive())
        {
            GetComponent<Light>().enabled = false;
            return true;
        }
        return false;
    }

    public ICursorUser ChangeUser(Tile t)
    {
        return this;
    }
}
