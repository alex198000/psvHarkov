using DG.Tweening;
using UnityEngine;

namespace Levels
{
    public class ButtonsControl : MonoBehaviour
    {
        [SerializeField] private MyPlayerMovement myPlayerMovement;
        [SerializeField] private GameObject _canvasPanel;
        [SerializeField] private GameObject _winPanel;
        [SerializeField] private GameObject _defeatPanel;
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private Transform _cameraPosition;

        private Tween _tween = null;

        void Update()
        {
            MooveBut();
            ESCbutton();
        }
        public void MooveBut()                        // управление с клавиатуры
        {
            if (Input.GetButton("Jump") || Input.GetButton("Vertical") || Input.GetButton("Debug Vertical")) // Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)
            {
                myPlayerMovement.Jump();
            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                myPlayerMovement.LeftMove();
            }
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                myPlayerMovement.StopMove();
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                myPlayerMovement.RightMove();
            }
            if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                myPlayerMovement.StopMove();
            }
        }
        void ESCbutton()                             // кнопка esc или  шаг назад на телефоне
        {
            if (Input.GetKeyDown(KeyCode.Escape) && _canvasPanel.activeSelf == true && _winPanel.transform.position.y < 0 && _defeatPanel.transform.position.y < 0 && _pausePanel.transform.position.y < 0)
            {
                _tween = _pausePanel.transform.DOMove(new Vector3(_cameraPosition.position.x, _cameraPosition.position.y, 0), 1f, true).SetEase(Ease.InBack).SetUpdate(true);
                _canvasPanel.SetActive(false);
                Time.timeScale = 0;               
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && _pausePanel.transform.position.y >= 0)
            {
                _canvasPanel.SetActive(true);
                _tween = _pausePanel.transform.DOMove(new Vector3(0, _cameraPosition.position.y - 15, 0), 1f, true).SetEase(Ease.InBack).SetUpdate(true);
                Time.timeScale = 1;
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
