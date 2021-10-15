using UnityEngine;

namespace Level1
{
    public class SuperMushroom : BaseFructs
    {
        [SerializeField] private GameObject winGame;

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }
        public override void Contact()
        {
            GameObject bonusEffect =  Instantiate(effect, transform.position, transform.rotation);
            Destroy(bonusEffect, 5f);
            winGame.SetActive(true);
        }
    }
}
