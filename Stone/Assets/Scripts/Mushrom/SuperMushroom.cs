using UnityEngine;

namespace Level1
{
    public class SuperMushroom : BaseFructs
    {
        [SerializeField] private GameObject _winGame;
        public override void Contact()
        {
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
