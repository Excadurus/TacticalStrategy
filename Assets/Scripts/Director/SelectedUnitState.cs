using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedUnitState : DirectorState
{
    public SelectedUnitState(Director director, DirectorStateMachine dsm, Faction faction) : base(director, dsm, faction)
    {
        InputWrapper.ActionSelectionInteract += SelectAction;
        InputWrapper.ActionSelectionCancel += Cancel;
    }

    public override void Exit()
    {
        director.selectedUnit = null;
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

    private void SelectAction()
    {
        director.selectedAction = director.selectedUnit.moveAction;
        //dsm.changeState();
    }

    private void Cancel()
    {
        director.selectedUnit.GetComponent<Light>().enabled = false;
        dsm.changeState(dsm.PlayerActionState);
    }

}
