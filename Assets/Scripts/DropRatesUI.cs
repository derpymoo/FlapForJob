using UnityEngine;

public class DropRatesUI : MonoBehaviour
{
    public GameObject dropRatesPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OpenDropRates()
    {
        dropRatesPanel.SetActive(true);
    }

    public void CloseDropRates()
    {
        dropRatesPanel.SetActive(false);
    }
}
