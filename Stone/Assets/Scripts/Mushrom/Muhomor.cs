using UnityEngine;

namespace Level1
{
    public class Muhomor : BaseFructs
    {
        [SerializeField] private PlayerHealth playerHealth;
        [SerializeField] private GameObject defeatGame;

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }
        public override void Contact()
        {
            playerHealth.Die();
            GameObject danger = Instantiate(effect, transform.position, transform.rotation);
            Destroy(danger, 5f);
            defeatGame.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}

