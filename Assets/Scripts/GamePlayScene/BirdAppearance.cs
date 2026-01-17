using UnityEngine;

public class BirdAppearance : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] characters;

    void Awake()
    {
        Debug.Log("BirdAppearance Awake");

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer NOT assigned");
            return;
        }

        string selected = PlayerPrefs.GetString("SelectedCharacter", "");

        Debug.Log("SelectedCharacter = " + selected);

        foreach (Sprite s in characters)
        {
            Debug.Log("Checking sprite: " + s.name);

            if (s.name == selected)
            {
                spriteRenderer.sprite = s;
                Debug.Log("APPLIED SPRITE: " + s.name);
                return;
            }
        }

        Debug.LogWarning("No matching sprite found");
    }
}
