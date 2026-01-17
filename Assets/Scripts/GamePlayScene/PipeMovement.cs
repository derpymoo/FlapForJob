using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public GameObject pipePrefab;      // Pipe prefab with two colliders (body + score zone)
    public float spawnRate = 2f;       // Seconds between pipes
    public float heightRange = 2f;     // Max vertical offset
    public float destroyAfter = 15f;   // Destroy pipe after this many seconds

    private float timer = 0f;
    private BirdController bird;

    void Start()
    {
        bird = FindObjectOfType<BirdController>();
        timer = spawnRate; // spawn immediately after first tap
    }

    void Update()
    {
        if (bird == null || !bird.HasGameStarted())
            return;

        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        // Spawn pipe
        GameObject newPipe = Instantiate(pipePrefab);

        // Set position with vertical random offset
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange), 0);

        // Ensure main body collider has correct tag
        Transform body = newPipe.transform.Find("PipeBody"); // make sure your prefab has a child named "PipeBody" for the main collider
        if (body != null)
            body.tag = "Pipe";

        // Ensure score collider is correct
        Transform scoreZone = newPipe.transform.Find("ScoreZone"); // child named "ScoreZone"
        if (scoreZone != null)
            scoreZone.tag = "ScoreZone";

        // Destroy after some time to avoid clutter
        Destroy(newPipe, destroyAfter);
    }
}
