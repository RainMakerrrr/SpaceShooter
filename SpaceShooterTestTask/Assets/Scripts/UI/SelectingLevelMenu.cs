using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectingLevelMenu : MonoBehaviour
{
    [SerializeField] private Button _secondLevelButton;
    [SerializeField] private Button _thirdLevelButton;
    [SerializeField] private PlayerData _playerData;

    private void Update()
    {
        if (_playerData.CountOfAsteroids >= 25) _secondLevelButton.interactable = true; 
        if (_playerData.CountOfAsteroids >= 35) _thirdLevelButton.interactable = true;
    }

    public void FirstLevelHandler()
    {
        SceneManager.LoadScene(0);
        GameScore.Instance.SetDefaultData();
    }
    public void SecondLevelHandler()
    {
        SceneManager.LoadScene(3);
        GameScore.Instance.SetDefaultData();
    }

    public void ThirdLevelHandler()
    {
        SceneManager.LoadScene(4);
        GameScore.Instance.SetDefaultData();
    }
}
