using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
        private AudioSource audioSource;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
         audioSource = GetComponent<AudioSource>();
    }

    void LaunchBall()
    {
        float x = Random.Range(-1f, 1f); // Randomize direction
        Vector2 direction = new Vector2(x, 1).normalized;
        rb.linearVelocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Bottom"))
    {
        Debug.Log("Game Over!");
    }
}

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            Debug.Log("You Win!");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
        if (collision.gameObject.CompareTag("Bottom"))
        {
            Debug.Log("Game Over!");
        }
    }
}
