using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GridTile tilePrefab;
    [SerializeField]
    private int width, height;
    public GridTile[,] grid { get; private set; }

    public void InitGrid()
    {
        grid = new GridTile[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GridTile tile = Instantiate(tilePrefab);
                tile.Init(new Coord(x, y), transform);
                grid[x, y] = tile;
            }
        }
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GridTile tile = grid[x, y];
                if (x > 0)
                {
                    tile.neighbors.Add(Coord.left, grid[x - 1, y]);
                }
                if(x < width - 1)
                {
                    tile.neighbors.Add(Coord.right, grid[x + 1, y]);
                }
                if(y > 0)
                {
                    tile.neighbors.Add(Coord.down, grid[x, y - 1]);
                }
                if(y < height - 1)
                {
                    tile.neighbors.Add(Coord.up, grid[x, y + 1]);
                }
            }
        }
    }

    
    void Update()
    {
        
    }
}
