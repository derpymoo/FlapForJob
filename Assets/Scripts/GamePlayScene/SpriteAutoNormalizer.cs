using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteAutoNormalizer : MonoBehaviour
{
    [Tooltip("Target height in world units (match your original bird)")]
    public float targetHeight = 1f;

    private SpriteRenderer sr;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Normalize()
    {
        if (sr.sprite == null)
        {
            Debug.LogWarning("No sprite to normalize.");
            return;
        }

        float spriteHeight = sr.sprite.bounds.size.y;
        float scaleFactor = targetHeight / spriteHeight;

        transform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
    }
}
