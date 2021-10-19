using UnityEngine;

namespace Levels
{
    public class Banana : BaseFructs
    {
        //private void Start()
        //{
        //    _particleFruit.Stop();
        //}
        public override void Contact()
        {
           // if (_particleFruit.isStopped)
                _particleFruit.Play();
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }
    }
}

