using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Action Director", menuName = "Directors/Action Director", order = 4)]

public class ActionDirector : ScriptableObject
{
    //TODO: Check pass by reference and value
    private Unit activeUnit;
    private UnitActions activeAction;

    private void Awake()
    {
        activeUnit = null;
        activeAction = null;
    }

    private void OnDisable()
    {
        activeUnit = null;
        activeAction = null;
    }


    public void SetActiveUnit(Unit u)
    {
        this.activeUnit = u;
    }

    public void SetActiveAction(UnitActions a)
    {
        this.activeAction = a;
    }

    public void ClearActiveUnit()
    {
        this.activeUnit = null;
    }

    public void ClearActiveAction()
    {
        this.activeAction = null;
    }

    public Unit GetActiveUnit()
    {
        return this.activeUnit;
    }

    public UnitActions GetActiveAction()
    {
        return this.activeAction;
    }

}
