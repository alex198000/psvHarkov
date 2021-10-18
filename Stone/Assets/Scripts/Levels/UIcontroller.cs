using UnityEngine;
using UnityEngine.UI;

namespace Levels
{
    public class UIcontroller : MonoBehaviour
    {
        [SerializeField] private Text _textScore;
        [SerializeField] private int _score;
        private void OnEnable()
        {
            ContactScript.OnScorePlus += UpdateScore;
        }

        private void OnDisable()
        {
            ContactScript.OnScorePlus -= UpdateScore;
        }
       public int Score {  get { return _score; } set { _score = value; } }
        public void UpdateScore()
        {
            _textScore.text = _score.ToString();
        }       
    }
}
