using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool gameStarted = false;

    void Start()
    {
        string selectedName = PlayerPrefs.GetString("SelectedCharacter", "DefaultBird");
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        // Assign sprite
        Sprite[] allSprites = Resources.LoadAll<Sprite>("Animals"); // folder with animal sprites
        foreach (Sprite s in allSprites)
        {
            if (s.name == selectedName)
            {
                sr.sprite = s;
                break;
            }
        }
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;   // freeze physics at start
    }

    void Update()
    {
        if (!gameStarted)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }
            return;
        }

        // Gameplay input
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    void StartGame()
    {
        gameStarted = true;
        rb.simulated = true;    // enable physics
        rb.linearVelocity = Vector2.up * jumpForce;
    }

    public bool HasGameStarted()
    {
        return gameStarted;
    }
}
