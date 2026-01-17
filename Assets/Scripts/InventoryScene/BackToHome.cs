using UnityEngine;

public class BackToHome : MonoBehaviour
{
    public void LoadHomePage()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
}
