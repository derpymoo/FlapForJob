using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GamePlayPage");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("HomePage");
    }
}
