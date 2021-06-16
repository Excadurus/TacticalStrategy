using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{


    [SerializeField] public Tile tile;
    [SerializeField] int hp = 20;
    [SerializeField] int dmg = 10;
    [SerializeField] int movementRange = 5;
    [SerializeField] public List<UnitActions> Actions;


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

    }

    public virtual void Attack(Unit target)
    {
        target.hp -= Mathf.Clamp(dmg, 0, target.hp);
    }

    //TODO: create this when tiles are implemented
    //public virtual int ReturnMovementCost()


    public bool IsActive()
    {
        return true;
    }
   
}
