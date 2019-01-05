using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Services.gameManager = this;
        Services.breedManager = new BreedManager();
    }
}
