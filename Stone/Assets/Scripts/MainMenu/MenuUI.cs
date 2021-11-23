using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class MenuUI : MonoBehaviour
    {
        [SerializeField] private GameObject _canvasPanel;
        [SerializeField] private GameObject _levelPanel;
        [SerializeField] private GameObject _fruitPanel;
        [SerializeField] private GameObject _exitPanel;

        private Tween _tween = null;

        public void Update()
        {
            ESCbutton();
        }
        public void Level1()
        {
            SceneManager.LoadScene(1);
        }
        public void Level2()
        {
            SceneManager.LoadScene(2);
        }
        public void Level3()
        {
            SceneManager.LoadScene(3);
        }

        public void NoButton()
        {
            _tween = _exitPanel.transform.DOMove(new Vector3(+20, 0, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
            _canvasPanel.SetActive(true);
        }

        public void ExitMenu()
        {
            if(_exitPanel.transform.position.y == 0)
            {
                _tween = _exitPanel.transform.DOMove(new Vector3(0, 0, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
                _canvasPanel.SetActive(false);
            }            
        }
        public void Quit()
        {
            Application.Quit();
        }

        void ESCbutton()                             // кнопка esc или  шаг назад на телефоне
        {
            if (Input.GetKeyDown(KeyCode.Escape) && _canvasPanel.activeSelf == true && _levelPanel.transform.position.y != 0 && _fruitPanel.transform.position.y != 0)
            {
                _tween = _exitPanel.transform.DOMove(new Vector3(0, 0, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
                _canvasPanel.SetActive(false);

            }
            else if (Input.GetKeyDown(KeyCode.Escape) && _exitPanel.transform.position.y == 0)
            {
                _canvasPanel.SetActive(true);
                _tween = _exitPanel.transform.DOMove(new Vector3(+20, 0, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
            }
            if (Input.GetKeyDown(KeyCode.Escape) && _levelPanel.transform.position.y == 0)
            {
                _canvasPanel.SetActive(true);
                _tween = _levelPanel.transform.DOMove(new Vector3(0, +11, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
                
            }
            if (Input.GetKeyDown(KeyCode.Escape) && _fruitPanel.transform.position.y == 0)
            {
                _canvasPanel.SetActive(true);
               
                _tween = _fruitPanel.transform.DOMove(new Vector3(0, -11, 0), 1f, true).SetEase(Ease.InOutBack).SetUpdate(true);
            }
        }

        private void OnDisable()
        {
            if (DOTween.instance != null)
            {
                _tween?.Kill();
            }
        }
    }
}

