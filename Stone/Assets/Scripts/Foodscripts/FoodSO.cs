using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodData", menuName = "ScriptableObjects/Food", order = 1)]
public class FoodSO : ScriptableObject
{

    [Tooltip("Food Sprite")]
    [SerializeField] private Sprite foodSprite;
    public Sprite FoodSprite
    {
        get { return foodSprite; }
    }

    [Tooltip("Food Value")]
    [SerializeField] private float foodValue;
    public float FoodValue
    {
        get { return foodValue; }
    }
}
