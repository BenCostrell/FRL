using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Player player;
    // Start is called before the first frame update
    public void InitCamera(Player player)
    {
        this.player = player;
        transform.position = new Vector3(
            player.transform.position.x,
            player.transform.position.y - 1,
            transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //if (player) TrackPlayer();
    }

    private void TrackPlayer()
    {
        Vector3 target = new Vector3(
            player.transform.position.x,
            player.transform.position.y,
            transform.position.z);
        transform.position = Vector3.Lerp(transform.position, target, 0.2f);
    }
}
