using UnityEngine;

public class Cursor : MonoBehaviour
{


    [SerializeField] public Tile tile;
    [SerializeField] public GameBoard gameboard;


    public Unit selectedUnit;

    private CursorStateMachine csm;


    // Start is called before the first frame update
    void Start()
    {
        transform.SetParent(tile.transform);
        csm = new CursorStateMachine(this);
        csm.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        csm.currentState.Update();
        transform.SetParent(tile.transform);
        transform.localPosition = new Vector3(0, 0.5f, 0);
    }

   public int getBoardLength()
    {
        return gameboard.rows[0].tiles.Length;
    }

    public int getBoardWidth()
    {
        return gameboard.rows.Length;
    }

}
