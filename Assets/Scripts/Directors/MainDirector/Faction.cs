using UnityEngine;

public class Faction : MonoBehaviour
{
    [SerializeField] Unit[] units;
    [SerializeField] public bool isPlayer;
    // Start is called before the first frame update


    public void ActivateFactionUnits()
    {
        foreach(Unit u in units)
        {
            //handle unit activation
        }
    }
}
