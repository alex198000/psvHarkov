using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level1
{
    [RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
    public class MyPlayerMovement : MonoBehaviour
    {
        [Header("Player Property")]
        [SerializeField] private float playerSpeed;
        [SerializeField] private float playerJumpForce;
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject animObject;
        [SerializeField] private Animator animator;
        private Rigidbody2D rb;
        private SpriteRenderer spriteRenderer;
        private float currentPlayerSpeed;
        private bool groundCheck;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            rb.velocity = new Vector2(currentPlayerSpeed * Time.deltaTime, rb.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(currentPlayerSpeed));
        }

        public void RightMove()
        {
            currentPlayerSpeed = playerSpeed;
            player.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        public void LeftMove()
        {
            currentPlayerSpeed = -playerSpeed;
            player.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }


        public void StopMove()
        {
            currentPlayerSpeed = 0f;
        }
        public void Jump()
        {
            if (groundCheck)
            {
                animator.SetTrigger("Jump");
                rb.velocity = new Vector2(rb.velocity.x, playerJumpForce);
                groundCheck = false;
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            groundCheck = true;
        }

    }
}


