using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CreateAssetMenu]

public class Director : ScriptableObject
{
    [SerializeField] public Cursor cursor;
    [SerializeField] public InputWrapper inputWrapper;

    [HideInInspector] public Unit selectedUnit;
    [HideInInspector] public UnitActions selectedAction;



    //TODO: Handle Inputting Factions and their orders. affects DSM and Turn increment in States



    private void Awake()
    {
        selectedUnit = null;
        selectedAction = null;
    }


    #region Setters

    #endregion
}
