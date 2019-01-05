using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBreedSprites", menuName = "Data/BreedSprites")]
public class BreedSprites : ScriptableObject
{
    public Sprite[] growingSprites;
    public Sprite[] fullyGrownSprites;
}
