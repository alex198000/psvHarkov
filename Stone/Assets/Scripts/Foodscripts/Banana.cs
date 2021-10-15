using UnityEngine;

namespace Level1
{
    public class Banana : BaseFructs
    {
        [SerializeField] private ContactScript _contactScript;
        private void OnEnable()
        {
            //_contactScript.ScorePlus += updateScore(bonus);
        }

        private void OnDisable()
        {
            //_contactScript.ScorePlus -= updateScore(bonus);
        }
        public override void Contact()
        {
            Instantiate(effect, transform.position, transform.rotation);
        }
    }
}

