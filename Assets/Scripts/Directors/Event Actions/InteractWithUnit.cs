using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Interact With Unit Event Actions",menuName ="State Machines/States/Event Actions/Interact With Unit",order = 2)]
public class InteractWithUnit : StateEventAction
{
    [SerializeField] TranistionFlag unitSelectedFlag;
    [SerializeField] ActionDirector actionDirector;
    [SerializeField] Cursor cursor;
    protected override void Act()
    {
        Unit u = cursor.getTile().unit;
        if(u!=null && u.IsActive()){
            unitSelectedFlag.Set();
            u.GetComponentInChildren<Light>().enabled = true;
            actionDirector.SetActiveUnit(u);
        }
    }
}
