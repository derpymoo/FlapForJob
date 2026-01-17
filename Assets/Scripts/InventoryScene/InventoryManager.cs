using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject characterSlotPrefab;  // prefab of CharacterSlot
    public Transform gridParent;            // Content of ScrollView
    public Image selectedCharacterImage;    // image to show selected character
    public Sprite[] allCharacters;          // all sprites

    void Start()
    {
        PopulateInventory();
        LoadSelectedCharacter();
    }

    void PopulateInventory()
    {
        if (gridParent == null || characterSlotPrefab == null)
        {
            Debug.LogError("GridParent or CharacterSlotPrefab not assigned!");
            return;
        }

        // clear old slots
        foreach (Transform child in gridParent)
            Destroy(child.gameObject);

        foreach (Sprite character in allCharacters)
        {
            int unlocked = PlayerPrefs.GetInt("Unlocked_" + character.name, 0);
            if (unlocked == 1)
            {
                GameObject slotObj = Instantiate(characterSlotPrefab, gridParent);
                CharacterSlot slotComp = slotObj.GetComponent<CharacterSlot>();
                if (slotComp != null)
                {
                    slotComp.Setup(character, SelectCharacter);
                }
                else
                {
                    Debug.LogError("CharacterSlot script missing on prefab!");
                }
            }
        }
    }

    void SelectCharacter(Sprite character)
    {
        if (selectedCharacterImage != null)
        {
            selectedCharacterImage.sprite = character;
            PlayerPrefs.SetString("SelectedCharacter", character.name);
            PlayerPrefs.Save();
            Debug.Log("Selected character: " + character.name);
        }
        else
        {
            Debug.LogError("selectedCharacterImage not assigned!");
        }
    }

    void LoadSelectedCharacter()
    {
        string selectedName = PlayerPrefs.GetString("SelectedCharacter", "");
        if (!string.IsNullOrEmpty(selectedName) && selectedCharacterImage != null)
        {
            foreach (Sprite s in allCharacters)
            {
                if (s.name == selectedName)
                {
                    selectedCharacterImage.sprite = s;
                    break;
                }
            }
        }
    }
}
