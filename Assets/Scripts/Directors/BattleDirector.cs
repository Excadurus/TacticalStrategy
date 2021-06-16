using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class BattleDirector : ScriptableObject
{
    //Add General Variables such as crit rate and etc here


    public void ConductBattle(Unit attacker, Unit defender)
    {
        defender.hp -= Mathf.Clamp(attacker.dmg, 0, defender.hp);
    }

}
