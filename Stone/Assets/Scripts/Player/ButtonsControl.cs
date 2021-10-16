using UnityEngine;

namespace Levels
{
    public class ButtonsControl : MonoBehaviour
    {
        [SerializeField] MyPlayerMovement myPlayerMovement;
        [SerializeField] private GameObject _canvasPanel;
        [SerializeField] private GameObject _winPanel;
        [SerializeField] private GameObject _defeatPanel;
        [SerializeField] private GameObject _pausePanel;
        void Update()
        {
            MooveBut();
            ESCbutton();
        }
        public void MooveBut()
        {
            if (Input.GetButton("Jump"))
            {
                myPlayerMovement.Jump();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                myPlayerMovement.LeftMove();
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                myPlayerMovement.StopMove();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                myPlayerMovement.RightMove();
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                myPlayerMovement.StopMove();
            }
        }
        void ESCbutton()                             // кнопка esc или  шаг назад на телефоне
        {
            if (Input.GetKeyDown(KeyCode.Escape) && _canvasPanel.activeSelf == true && _winPanel.activeSelf == false && _defeatPanel.activeSelf == false && _pausePanel.activeSelf == false)
            {
                _pausePanel.SetActive(true);
                _canvasPanel.SetActive(false);
                Time.timeScale = 0;               
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && _pausePanel.activeSelf == true)
            {
                _canvasPanel.SetActive(true);
                _pausePanel.SetActive(false);
                Time.timeScale = 1;
            }                    
        }
    }
}
