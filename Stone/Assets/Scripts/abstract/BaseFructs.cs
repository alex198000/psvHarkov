using UnityEngine;

namespace Level1
{
    public abstract class BaseFructs : MonoBehaviour
    {
        [SerializeField] protected int bonus;
        [SerializeField] protected GameObject effect;

        public abstract void Contact();
    }
}

