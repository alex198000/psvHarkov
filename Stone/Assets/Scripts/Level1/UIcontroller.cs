using UnityEngine;
using UnityEngine.UI;

namespace Level1
{
    public class UIcontroller : MonoBehaviour
    {
        [SerializeField] private Text _textScore;
        [SerializeField] public int score;
        private void OnEnable()
        {
            ContactScript.ScorePlus += UpdateScore;
        }

        private void OnDisable()
        {
            ContactScript.ScorePlus -= UpdateScore;
        }

        public void UpdateScore()
        {
            _textScore.text = score.ToString();
        }

       
    }
}
