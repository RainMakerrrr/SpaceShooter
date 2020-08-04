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

    public void LevelLoader(int index)
    {
        SceneManager.LoadScene(index);
        GameScore.Instance.SetDefaultData();
    }

    
}
