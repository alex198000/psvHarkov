using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level1
{
    public abstract class Alive : MonoBehaviour
    {
        [SerializeField] protected int Health;
        public abstract void Die();
    }
}

