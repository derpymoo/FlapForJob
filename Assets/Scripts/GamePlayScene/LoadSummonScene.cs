using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSummonScene : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GachaScene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("HomePage");
    }
}