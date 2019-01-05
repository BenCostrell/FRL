using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridManager : MonoBehaviour
{
    public GridTile tilePrefab;
    public Plant plantPrefab;
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
        //temp
        for (int i = 0; i < 5; i++)
        {
            int x = UnityEngine.Random.Range(0, width);
            int y = UnityEngine.Random.Range(0, height);
            if (grid[x, y].gridObjects.Count == 0)
            {
                Plant plant = Instantiate(plantPrefab);
                plant.Init(grid[x, y], 
                    Services.breedManager.breeds[BreedManager.BreedType.BasicPlant]);
            }
        }
    }

    
    void Update()
    {
        
    }
}
