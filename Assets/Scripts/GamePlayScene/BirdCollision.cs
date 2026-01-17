using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdCollision : MonoBehaviour
{
    private bool isDead = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        BirdController bc = GetComponent<BirdController>();
        if (bc != null && !bc.HasGameStarted()) return;

        GameObject hitObj = collision.gameObject;

        // Check parent if bird hits child collider
        if (!hitObj.CompareTag("Pipe") && hitObj.transform.parent != null)
            hitObj = hitObj.transform.parent.gameObject;

        if (hitObj.CompareTag("Pipe"))
        {
            isDead = true;

            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
                rb.simulated = false;
            }

            SceneManager.LoadScene("DeathScreenScene"); // load the death screen scene
        }
    }
}
