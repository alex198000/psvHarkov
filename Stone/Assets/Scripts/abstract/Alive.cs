using UnityEngine;

namespace Level1
{
    public abstract class Alive : MonoBehaviour
    {
        [SerializeField] protected int Health;
        public abstract void Die();
    }
}

