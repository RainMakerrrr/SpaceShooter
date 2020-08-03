using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    public void StartPlay()
    {
        if (_playerData.CountOfAsteroids >= 25) _playerData.CountOfAsteroids = 0;
        SceneManager.LoadScene(0);
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}
