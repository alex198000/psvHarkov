using UnityEngine;

namespace Levels
{
    public class Mushroom : BaseFructs
    {
        public override void Contact()
        {
            GameObject bonusEffect = Instantiate(_effect, transform.position, transform.rotation);
            Destroy(bonusEffect, 5f);
        }

        public override void UpdateScore()
        {
            _uiController.score += bonus; 
        }
    }
}

