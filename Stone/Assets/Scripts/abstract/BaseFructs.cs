using UnityEngine;

namespace Levels
{
    public abstract class BaseFructs : MonoBehaviour
    {
        [SerializeField] public int bonus;
        [SerializeField] protected GameObject _effect;
        [SerializeField] protected UIcontroller _uiController;

        public abstract void Contact();
        public abstract void UpdateScore();
    }
}

