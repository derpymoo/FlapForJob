using UnityEngine;

public class GachaManager : MonoBehaviour
{
    [Header("UI")]
    public Canvas gachaCanvas;
    public Canvas animationCanvas;

    public void StartSummon()
    {
        // Hide main UI
        gachaCanvas.gameObject.SetActive(false);

        // Show animation UI
        animationCanvas.gameObject.SetActive(true);

        // Start animation
        StartCoroutine(PlaySummonAnimation());
    }

    System.Collections.IEnumerator PlaySummonAnimation()
    {
        // Placeholder delay for animation
        yield return new WaitForSeconds(2f);

        // Animation finished
        animationCanvas.gameObject.SetActive(false);
        gachaCanvas.gameObject.SetActive(true);

        Debug.Log("Summon complete!");
    }
}
