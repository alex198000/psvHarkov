using UnityEngine;

namespace Levels
{
    public class Banana : BaseFructs
    {       
        public override void Contact()
        {
            _particleFruit.Play();
        }
        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }
    }
}

