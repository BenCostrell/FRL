using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BreedManager
{
    public readonly Dictionary<BreedType, Breed> breeds;
    public enum BreedType { BasicPlant };

    public BreedManager()
    {
        breeds = new Dictionary<BreedType, Breed>();
        breeds.Add(BreedType.BasicPlant, new Breed("Basic", BreedType.BasicPlant,
            10, new List<Use>(),
            Resources.Load<BreedSprites>("Data/BreedSprites/BasicPlant")));
    }
}
