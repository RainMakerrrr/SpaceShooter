using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
        GameScore.Instance.SetDefaultData();
    }

}
