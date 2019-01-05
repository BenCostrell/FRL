using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour
{
    public Coord coord { get; private set; }

    public List<GridObject> gridObjects;

    public Dictionary<Coord, GridTile> neighbors;

    public void Init(Coord coord, Transform parent)
    {
        this.coord = coord;
        transform.parent = parent;
        transform.localPosition = new Vector3(coord.x, coord.y);
        gridObjects = new List<GridObject>();
        neighbors = new Dictionary<Coord, GridTile>();
    }

    void Update()
    {
        
    }
}

public struct Coord
{
    public int x, y;

    public static Coord up = new Coord(0, 1);
    public static Coord down = new Coord(0, -1);
    public static Coord left = new Coord(-1, 0);
    public static Coord right = new Coord(1, 0);
    public static Coord[] directions = new Coord[] { up, right, down, left };

    public static Coord zero = new Coord(0, 0);

    public Coord (int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Coord Add(Coord other)
    {
        return new Coord(x + other.x, y + other.y);
    }


}
