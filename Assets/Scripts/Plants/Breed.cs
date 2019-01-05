using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Breed
{
    public readonly string name;
    public readonly BreedManager.BreedType breedType;
    public readonly int growthTime;
    public readonly BreedSprites breedSprites;
    public readonly List<Use> uses;

    public Breed(string name, BreedManager.BreedType breedType,
        int growthTime, List<Use> uses, BreedSprites breedSprites)
    {
        this.name = name;
        this.breedType = breedType;
        this.growthTime = growthTime;
        this.uses = uses;
        this.breedSprites = breedSprites;
    }

    public virtual void OnUse()
    {
        foreach(Use use in uses)
        {
            use.OnUse();
        }
    }
}
