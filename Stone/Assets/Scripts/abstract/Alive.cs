using UnityEngine;

namespace Levels
{
    public abstract class Alive : MonoBehaviour
    {
        [SerializeField] protected int Health;
        public abstract void Die();
        public abstract void Win();
    }
}

