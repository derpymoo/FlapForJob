using UnityEngine;
using TMPro;

public class RunCoinUI : MonoBehaviour
{
    public TMP_Text coinText;  // assign in Inspector

    void Update()
    {
        if (GameManager.instance != null)
        {
            coinText.text = "Coins: " + GameManager.instance.runCoins;
        }
    }
}
