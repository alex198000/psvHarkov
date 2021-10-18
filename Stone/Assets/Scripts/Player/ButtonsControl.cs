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
