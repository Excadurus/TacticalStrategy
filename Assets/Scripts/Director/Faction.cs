using UnityEngine;

public class Faction : MonoBehaviour
{
    [SerializeField] Unit[] units;
    // Start is called before the first frame update


    public void ActivateFactionUnits()
    {
        foreach(Unit u in units)
        {
            u.ActivateUnit();
        }
    }
}
