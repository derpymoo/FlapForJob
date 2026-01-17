using UnityEngine;

public class MainMenuLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
    }
}
