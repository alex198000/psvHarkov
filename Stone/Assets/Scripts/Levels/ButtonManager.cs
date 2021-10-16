using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Levels
{
    public class ButtonManager : MonoBehaviour
    {
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private GameObject _canvasPanel;

        public void NextLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
        }
        public void Repeat()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }

        public void Menu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }

        public void Resume()
        {
            _canvasPanel.SetActive(true);
            _pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

}


