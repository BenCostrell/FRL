using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GridObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ListenForInput();   
    }

    private void ListenForInput()
    {
        bool move = false;
        Coord direction = Coord.zero;
        if (Input.GetKeyDown(KeyCode.W))
        {
            move = true;
            direction = Coord.up;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            move = true;
            direction = Coord.right;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            move = true;
            direction = Coord.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            move = true;
            direction = Coord.left;
        }
        if (move) Move(direction);
    }

    private void Move(Coord direction)
    {
        if (tile.neighbors.ContainsKey(direction))
        {
            GridTile target = tile.neighbors[direction];
            PlaceOnTile(target);
            Services.mainSceneManager.Tick();
        }
    }
}
