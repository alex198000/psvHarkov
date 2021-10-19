using UnityEngine;

namespace Levels
{
    public abstract class BaseFructs : MonoBehaviour
    {
        [SerializeField] public int bonus;
        //[SerializeField] protected GameObject _effect;
        [SerializeField] protected UIcontroller _uiController;
        [SerializeField] protected ParticleSystem _particleFruit;
        [SerializeField] protected ParticleSystem _particleMush;
        [SerializeField] protected ParticleSystem _particleWin;
        [SerializeField] protected ParticleSystem _particleDefeat;

        //private void Start()
        //{
        //    _particleFruit.Stop();
        //}
        public abstract void Contact();
        public abstract void UpdateScore();
    }
}

