using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameStateHandler : MonoBehaviour
{
    [SerializeField] private Image _winImage;
    [SerializeField] private Image _loseImage;
    

    private PlayerStats _playerStats;

    private void Start()
    {
        _playerStats = FindObjectOfType<PlayerStats>();

        _playerStats.OnDie += LoseGame;
        GameScore.Instance.OnAchievementDesiredNubmer += WinGame;
    }
    private void LoseGame()
    {
        StartCoroutine(LoseGameRoutine());
    }
    private void WinGame()
    {
        StartCoroutine(WinGameRoutine());
    }

    private IEnumerator WinGameRoutine()
    {
        _winImage.gameObject.SetActive(true);
        AudioManager.Instance.Play(2);

        yield return new WaitForSeconds(3f);
   
        SceneManager.LoadScene(1);
        Debug.Log(PlayerPrefs.GetString("Completed"));
    }
    private IEnumerator LoseGameRoutine()
    {
        _loseImage.gameObject.SetActive(true);
        AudioManager.Instance.Play(3);

        yield return new WaitForSeconds(3f);
        GameScore.Instance.SetDefaultData();

        SceneManager.LoadScene(1);
    }
}
