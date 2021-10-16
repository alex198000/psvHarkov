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
            GameObject danger = Instantiate(_effect, transform.position, transform.rotation);
            Destroy(danger, 5f);
            _defeatGame.SetActive(true);
            //Time.timeScale = 0;
        }

        public override void UpdateScore()
        {
            _uiController.score += bonus;
        }
    }
}

