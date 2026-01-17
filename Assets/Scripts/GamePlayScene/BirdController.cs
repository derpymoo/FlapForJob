using UnityEngine;


public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool gameStarted = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;   // FREEZE physics at start
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

        // Normal gameplay input
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    void StartGame()
    {
        gameStarted = true;
        rb.simulated = true;    // ENABLE physics
        rb.linearVelocity = Vector2.up * jumpForce;
    }

    public bool HasGameStarted()
    {
        return gameStarted;
    }
}
