using UnityEngine;

public class InventorySceneLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadInventoryScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InventoryScene");
    }
}
