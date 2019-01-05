using UnityEngine;
using System.Collections;

public class GridObject : MonoBehaviour
{
    public GridTile tile { get; private set; }

    public void PlaceOnTile(GridTile tile)
    {
        if (this.tile != null)
        {
            this.tile.gridObjects.Remove(this);
        }
        this.tile = tile;
        transform.parent = tile.transform;
        transform.localPosition = Vector3.zero;
    }
}
