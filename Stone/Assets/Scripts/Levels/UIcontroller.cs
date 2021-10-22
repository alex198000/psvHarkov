using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Levels
{
    public class UIcontroller : MonoBehaviour
    {
        [SerializeField] private Image _winImage;
        [SerializeField] private Image _defeatImage;
        //[SerializeField] private Image _canvasImage;
        [SerializeField] private Text _textScore;
        [SerializeField] private int _score;
        //[SerializeField] private GameObject _panelCanvas;
        [SerializeField] private GameObject _winPanel;
        [SerializeField] private GameObject _defeatPanel;
        private Tween _tween;

        public int Score { get { return _score; } set { _score = value; } }   // сврйства счета, чтобы поле было приватным


        private void OnEnable()                                      //подписываемся на контакты
        {
            ContactScript.OnScorePlus += UpdateScore;
            SuperMushroom.OnPlayerWin += PlayerWin;
            Muhomor.OnPlayerDefeat += PlayerDefeat;
            ButtonManager.OnNextLevel += LevelClosed;
            ButtonManager.OnRepeatLevel += LevelRepeat;
        }

        private void OnDisable()                                    //отписываемся
        {
            ContactScript.OnScorePlus -= UpdateScore;
            SuperMushroom.OnPlayerWin -= PlayerWin;
            Muhomor.OnPlayerDefeat -= PlayerDefeat;
            ButtonManager.OnNextLevel -= LevelClosed;
            ButtonManager.OnRepeatLevel -= LevelRepeat;
            _winImage.DOKill();
            //_canvasImage.DOKill();
        }
        private void Start()
        {
            LevelOpen();
        }
        public void UpdateScore()                                             //обновляем юай
        {
            _textScore.text = _score.ToString();
        }

        public void PlayerWin()                                             //обновляем юай win
        {
            _winPanel.SetActive(true);
        }

        public void PlayerDefeat()                                             //обновляем юай defeat
        {
            _defeatPanel.SetActive(true);
        }

        public void LevelClosed()
        {
            _tween = _winImage.DOFade(0, 2f).OnComplete(() => 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
            });
            Time.timeScale = 1;
            //_panelCanvas.SetActive(false);
        }

        public void LevelRepeat()
        {
            _tween = _defeatImage.DOFade(0, 4f).OnComplete(() =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            });
            Time.timeScale = 1;
            //_panelCanvas.SetActive(false);
        }
        public void LevelOpen()
        {
            //_tween = _canvasImage.DOFade(1, 2f);
            //_panelCanvas.SetActive(true);
        }
    }
}
