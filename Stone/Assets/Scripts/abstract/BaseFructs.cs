using UnityEngine;

namespace Levels
{
    public abstract class BaseFructs : MonoBehaviour
    {
        [SerializeField] protected int bonus;
        [SerializeField] protected GameObject _objDeactiv;
        [SerializeField] protected UIcontroller _uiController;
        [SerializeField] protected ParticleSystem _particle;
   
        public abstract void Contact();
        public abstract void UpdateScore();
        public abstract void DeActiv();
    }
}

