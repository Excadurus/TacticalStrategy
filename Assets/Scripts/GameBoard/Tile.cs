using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] public int row;
    [SerializeField] public int col;
    [SerializeField] public Unit unit;
    private Path path;
    //TODO: Handle Tile Content Here

    private void Awake()
    {
        path = null;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        unit = GetComponentInChildren<Unit>();
    }

    public void setPath(Path p)
    {
        path = p;
    }

    public bool CanMoveHere()
    {
        return path != null;
    }

    public void ClearPath()
    {
        path = null;
    }
}
