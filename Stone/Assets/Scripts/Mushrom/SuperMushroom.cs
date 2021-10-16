using UnityEngine;

namespace Levels
{
    public class SuperMushroom : BaseFructs
    {
        [SerializeField] private PlayerHealth _playerHealth;
        [SerializeField] private GameObject _winGame;
        public override void Contact()
        {
            _playerHealth.Win();
            GameObject bonusEffect =  Instantiate(_effect, transform.position, transform.rotation);
            Destroy(bonusEffect, 5f);
            _winGame.SetActive(true);
        }

        public override void UpdateScore()
        {
            _uiController.score += bonus;
        }
    }
}
