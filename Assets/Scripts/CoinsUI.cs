using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    public Text totalCoinsText;
    void Start()
    {
        if (GameManager.instance != null)
        {

            // Show total coins including this run
            totalCoinsText.text = "Total Coins: " + GameManager.instance.totalCoins;

        }
    }
}
