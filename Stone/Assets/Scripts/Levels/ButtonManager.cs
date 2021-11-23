using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Levels
{
    public class ButtonManager : MonoBehaviour
    {
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private GameObject _canvasPanel;
        [SerializeField] private Transform _cameraPosition;

        private Tween _tween = null;

        public static event Action OnNextLevel;
        public static event Action OnRepeatLevel;

        public void NextLevel()
        {
            OnNextLevel?.Invoke();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Time.timeScale = 1;
        }
        public void Repeat()
        {
            OnRepeatLevel?.Invoke();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //Time.timeScale = 1;
        }

        public void Menu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }

        public void Resume()
        {
            _tween = _pausePanel.transform.DOMove(new Vector3(_cameraPosition.position.x, _cameraPosition.position.y - 15, 0), 1f, true).SetEase(Ease.InBack).SetUpdate(true).OnComplete(() =>
            {
                _canvasPanel.SetActive(true);
                Time.timeScale = 1;
            });
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


