using UnityEngine;
using UnityEngine.UI;

public class BirdSelector : MonoBehaviour
{
    public SpriteRenderer birdRenderer; // If your bird is a normal GameObject
    // public Image birdImage; // If your bird is a UI Image instead

    void Start()
    {
        string selectedName = PlayerPrefs.GetString("SelectedCharacter", "");
        if (!string.IsNullOrEmpty(selectedName))
        {
            // Load all available sprites from Resources or assign them in inspector
            Sprite[] allBirds = Resources.LoadAll<Sprite>("Birds"); // Optional: store all bird sprites in Resources/Birds

            foreach (Sprite s in allBirds)
            {
                if (s.name == selectedName)
                {
                    if (birdRenderer != null)
                        birdRenderer.sprite = s;

                    // if using UI Image:
                    // if (birdImage != null)
                    //     birdImage.sprite = s;
                    break;
                }
            }
        }
    }
}

