using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int totalCoins = 0;
    public int runCoins = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        }
        else Destroy(gameObject);
    }

    public void StartNewRun() => runCoins = 0;
    public void AddCoin(int amount) => runCoins += amount;

    public void EndRun()
    {
        totalCoins += runCoins;
        PlayerPrefs.SetInt("TotalCoins", totalCoins);
        PlayerPrefs.Save();
    }
}
