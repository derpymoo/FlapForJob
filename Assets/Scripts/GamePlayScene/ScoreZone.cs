using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool scored = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !scored)
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.AddCoin(1);
                scored = true;
                Debug.Log("Coin scored! Run coins: " + GameManager.instance.runCoins);
            }
        }
    }
}
