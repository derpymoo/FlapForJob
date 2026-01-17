using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.StartNewRun();
        }
    }
}
