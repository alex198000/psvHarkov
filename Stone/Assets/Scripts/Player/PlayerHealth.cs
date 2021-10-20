using UnityEngine;

namespace Levels
{
    public class PlayerHealth : Alive
    {
        [SerializeField] private GameObject _defeatGame;
        [SerializeField] private GameObject _winGame;
        public override void Die()
        {
            gameObject.SetActive(false);
           _defeatGame.SetActive(true);
        }

        public override void Win()
        {
            gameObject.SetActive(false);
           _winGame.SetActive(true);
        }
    }    
}

