using UnityEngine;

public class CursorHandler : MonoBehaviour
{
    [SerializeField] public GameBoard gameboard;
    [SerializeField] public Tile baseTile;
    [SerializeField] private Cursor cursor;

    void Awake()
    {
        cursor.Initialize(this);   
    }

    void Update()
    {
        cursor.getTile();
        transform.SetParent(cursor.getTile().transform);
        transform.localPosition = new Vector3(0, 0.5f, 0);
    }
}
