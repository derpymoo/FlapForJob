using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenuController : MonoBehaviour
{
    public Text runCoinsText;
    public Text totalCoinsText;

    void Start()
    {
        if (GameManager.instance != null)
        {
            // Show run coins first
            runCoinsText.text = "Run Coins: " + GameManager.instance.runCoins;

            // Show total coins including this run
            int coinsIncludingRun = GameManager.instance.totalCoins + GameManager.instance.runCoins;
            totalCoinsText.text = "Total Coins: " + coinsIncludingRun;

            // Then update total coins in GameManager
            GameManager.instance.EndRun();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlayPage"); // replace with your gameplay scene name
    }

    public void GoHome()
    {
        SceneManager.LoadScene("HomePage"); // replace with your home scene name
    }
}
