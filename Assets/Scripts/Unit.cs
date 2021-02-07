﻿using UnityEngine;

public abstract class Unit : MonoBehaviour
{

    [SerializeField] public Tile tile;
    [SerializeField] private int hp = 20;
    [SerializeField] private int dmg = 10;
    [SerializeField] private int movementRange = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.hp == 0)
        {
            GameObject.Destroy(this);
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
