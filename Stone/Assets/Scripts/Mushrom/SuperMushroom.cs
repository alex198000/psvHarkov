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
            _particleWin.Play();
            _winGame.SetActive(true);
        }

        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }
    }
}
