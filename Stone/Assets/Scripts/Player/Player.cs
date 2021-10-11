using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameData gameData;

    public void UpdateHunger(float foodValue)
    {
        gameData.Hunger += foodValue/100f;
    }
}
