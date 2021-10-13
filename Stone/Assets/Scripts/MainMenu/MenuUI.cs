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

        public void ExitMenu()
        {
            _exitPanel.SetActive(true);
            _canvasPanel.SetActive(false);
        }
        public void Quit()
        {
            Application.Quit();
        }

        void ESCbutton()                             // кнопка esc или  шаг назад на телефоне
        {
            if (Input.GetKeyDown(KeyCode.Escape) && _canvasPanel.activeSelf == true && _levelPanel.activeSelf == false && _fruitPanel.activeSelf == false)
            {
                _exitPanel.SetActive(true);
                _canvasPanel.SetActive(false);

            }
            else if (Input.GetKeyDown(KeyCode.Escape) && _exitPanel.activeSelf == true)
            {
                _canvasPanel.SetActive(true);
                _exitPanel.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && (_levelPanel.activeSelf == true || _fruitPanel.activeSelf == true))
            {
                _canvasPanel.SetActive(true);
                _levelPanel.SetActive(false);
                _fruitPanel.SetActive(false);
            }

        }
    }
}

