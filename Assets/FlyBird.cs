using UnityEditor.Callbacks;
using UnityEngine;

public class FlyBird : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocity = 1f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // jump the bird up
            rb.linearVelocity = Vector2.up * velocity;
        }
    }
}
