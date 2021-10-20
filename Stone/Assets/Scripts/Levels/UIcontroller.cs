using UnityEngine;
using UnityEngine.UI;

namespace Levels
{
    public class UIcontroller : MonoBehaviour
    {
        [SerializeField] private Text _textScore;
        [SerializeField] private int _score;
        private void OnEnable()                                      //подписываемся на контакт со сьестным
        {
            ContactScript.OnScorePlus += UpdateScore;
        }

        private void OnDisable()                                    //отписываемся
        {
            ContactScript.OnScorePlus -= UpdateScore;
        }
       public int Score {  get { return _score; } set { _score = value; } }   // сврйства счета, чтобы поле было приватным
        public void UpdateScore()                                             //обновляем юай
        {
            _textScore.text = _score.ToString();
        }       
    }
}
