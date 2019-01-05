using UnityEngine;
using System.Collections;

public abstract class GridObject : MonoBehaviour
{
    public GridTile tile { get; private set; }

    public virtual void Init(GridTile tile)
    {
        Services.mainSceneManager.gridObjects.Add(this);
        PlaceOnTile(tile);
    }

    public void PlaceOnTile(GridTile tile)
    {
        if (this.tile != null)
        {
            this.tile.gridObjects.Remove(this);
        }
        this.tile = tile;
        this.tile.gridObjects.Add(this);
        transform.parent = tile.transform;
        transform.localPosition = Vector3.zero;
    }

    public virtual void OnTick()
    {

    }
}
