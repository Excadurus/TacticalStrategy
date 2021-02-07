using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] public int row;
    [SerializeField] public int col;
    [SerializeField] public Unit unit;
    //TODO: Handle Tile Content Here

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        unit = GetComponentInChildren<Unit>();
    }
}
