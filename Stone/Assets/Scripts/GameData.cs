using UnityEngine;
[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public string scoreValueName = "Score";
    public string openLevelsValueName = "OpenLevels";
    [SerializeField] private int score;
    [SerializeField] private int openLevels;
    [SerializeField] private float hunger;
    public float hungerRate;

    public float Hunger
    {
        get
        {
            if (hunger >= 1)
            {
                return 1;
            }
            else
            {
                return hunger;
            }
        }
        set
        {
            if (hunger <= 0)
            {
                hunger = 0;
            }
            else
            {
                hunger = value;
            }

        }
    }

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
    public int OpenLevels
    {
        get
        {
            if (openLevels < 1)
                return 1;
            else
                return openLevels;
        }
        set
        {
            openLevels = value;
        }
    }

    private void Awake()
    {
        // gameData.DeleteKeyData(openLevelsValueName);
        Score = GetData(scoreValueName, score);
        OpenLevels = GetData(openLevelsValueName, openLevels);
    }

    public void SaveData(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }
    public void SaveData()
    {
        SaveData(scoreValueName, Score);
        SaveData(openLevelsValueName, OpenLevels);
    }
    public int GetData(string KeyName, int defaultValue)
    {
        return PlayerPrefs.GetInt(KeyName, defaultValue);
    }
    public void DeleteKeyData(string KeyName)
    {
        PlayerPrefs.DeleteKey(KeyName);
    }
}
