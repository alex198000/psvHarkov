// https://docs.unity3d.com/ScriptReference/PlayerPrefs.html

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Image hungerImage;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameData gameData;

    private void Start()
    {
        scoreText.text = gameData.Score.ToString();
        gameData.Hunger = 1f;
    }

    void Update()
    {
        gameData.Hunger -= Time.deltaTime * gameData.hungerRate;
        hungerImage.fillAmount = gameData.Hunger;
    }

    private void CountScore()
    {
        gameData.Score += 10;
        scoreText.text = gameData.Score.ToString();
        CheckWin();
    }

    private void CheckWin()
    {
        if ((gameData.Score % 40) == 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == gameData.OpenLevels)
            {
                gameData.OpenLevels++;
            }
            gameData.SaveData();
            Debug.Log("YOU WIN!!!");
            SceneManager.LoadScene(0);
        }

    }
}


