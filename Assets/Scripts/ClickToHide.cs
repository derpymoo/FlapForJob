using UnityEngine;
using UnityEngine.UI;

public class ClickToHide : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
        }
    }
}    