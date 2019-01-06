using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    [SerializeField]
    private Player playerPrefab;
    private Player player;

    [SerializeField]
    private GridManager gridManager;

    [SerializeField]
    private CameraController cameraController;

    public List<GridObject> gridObjects;

    void Start()
    {
        Services.mainSceneManager = this;
        gridObjects = new List<GridObject>();
        gridManager.InitGrid();
        player = Instantiate(playerPrefab);
        player.Init(gridManager.grid[gridManager.width/2, gridManager.height/2]);
        cameraController.InitCamera(player);
    }

    void Update()
    {
        
    }

    public void Tick()
    {
        foreach(GridObject gridObject in gridObjects)
        {
            gridObject.OnTick();
        }
    }
}
