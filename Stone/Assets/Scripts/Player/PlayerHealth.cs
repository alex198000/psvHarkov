using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level1
{
    public class PlayerHealth : Alive
    {
        [SerializeField] private Animator animator;
        public override void Die()
        {
            // animator.Play("Die", 3);
        }


    }
}

