using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : GridObject
{
    private Breed breed;
    private int growthTimeRemaining;
    public bool grown { get { return growthTimeRemaining == 0; } }
    private int spriteIndex;
    private SpriteRenderer sr;
    private Sprite[] sprites;

    public void Init(GridTile tile, Breed breed)
    {
        base.Init(tile);
        this.breed = breed;
        sr = GetComponent<SpriteRenderer>();
        sprites = breed.breedSprites.growingSprites;
        SetSprite();
        growthTimeRemaining = breed.growthTime;
    }

    public override void OnTick()
    {
        if(growthTimeRemaining > 0)
        {
            growthTimeRemaining -= 1;
            if (grown)
            {
                sprites = breed.breedSprites.fullyGrownSprites;
                spriteIndex = -1;
            }
        }
        Animate();
    }

    private void Animate()
    {
        spriteIndex = (spriteIndex + 1) % sprites.Length;
        SetSprite();
    }

    private void SetSprite()
    {
        sr.sprite = sprites[spriteIndex];
    }
}
