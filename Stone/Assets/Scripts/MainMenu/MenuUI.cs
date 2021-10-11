using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class MenuUI : MonoBehaviour
    {
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
        public void Quit()
        {
            Application.Quit();
        }
    }
}
