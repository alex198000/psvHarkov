using System;
using UnityEngine;


public class Froot : MonoBehaviour
{
    [SerializeField] FoodSO food;
    SpriteRenderer spriteRenderer;



    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = food.FoodSprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();

        if (player != null)
        {
            player.UpdateHunger(food.FoodValue);
            gameObject.SetActive(false);
        }
    }
}
