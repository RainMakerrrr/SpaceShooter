using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameScore : MonoBehaviour
{
    public event UnityAction OnAchievementDesiredNubmer;

    [SerializeField] private Text ScoreText;
    public PlayerData PlayerData;
    public int MaxCountForLevel;
        
    public static GameScore Instance;
    
    private void Awake()
    {
        Instance = this;
       
    }
    public void UpdateScore()
    {
        ScoreText.text = "   SCORE:" + PlayerData.CountOfAsteroids;

        if (PlayerData.CountOfAsteroids == MaxCountForLevel) OnAchievementDesiredNubmer?.Invoke();
    }
    public void SetDefaultData()
    {
        PlayerData.CountOfAsteroids = 0;
        PlayerData.Health = 3;
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Score",PlayerData.CountOfAsteroids);
    }

    public void LoadData()
    {
        PlayerPrefs.GetInt("Score");
       
    }
}

