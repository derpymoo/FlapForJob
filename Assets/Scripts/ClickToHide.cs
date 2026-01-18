using UnityEngine;
using UnityEngine.UI;

public class ClickToHide : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
    }
}    