using UnityEngine;
using UnityEngine.UI;

public class CharacterSlot : MonoBehaviour
{
    public Image characterImage;   // drag CharacterImage here
    public Button selectButton;    // drag SelectButton here

    public void Setup(Sprite character, System.Action<Sprite> onClick)
    {
        if (characterImage != null)
            characterImage.sprite = character;

        if (selectButton != null)
        {
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(() => onClick(character));
        }
        else
            Debug.LogError("SelectButton not assigned!");
    }
}
