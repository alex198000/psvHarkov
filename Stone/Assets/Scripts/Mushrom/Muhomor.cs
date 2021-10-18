using UnityEngine;

namespace Levels
{
    public class Muhomor : BaseFructs
    {
        [SerializeField] private PlayerHealth _playerHealth;
        [SerializeField] private GameObject _defeatGame;
        public override void Contact()
        {
            _playerHealth.Die();
            _particleDefeat.Play();
            _defeatGame.SetActive(true);
            //Time.timeScale = 0;
        }

        public override void UpdateScore()
        {
            _uiController.Score += bonus;
        }
    }
}

