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

    void Start()
    {
        gridManager.InitGrid();
        player = Instantiate(playerPrefab);
        gridManager.grid[3, 4].PlaceObject(player);
        cameraController.InitCamera(player);
    }

    void Update()
    {
        
    }
}
