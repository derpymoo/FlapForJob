using UnityEngine;
using UnityEngine.SceneManagement;

public class GachaManager : MonoBehaviour
{
    public void Summon()
    {
        if (GameManager.instance.totalCoins < 10)
        {
            Debug.Log("Not enough coins!");
            return;
        }

        // Deduct coins
        GameManager.instance.totalCoins -= 10;
        PlayerPrefs.SetInt("TotalCoins", GameManager.instance.totalCoins);
        PlayerPrefs.Save();

        // Go to summoning scene
        SceneManager.LoadScene("SummoningScene");
    }
}
