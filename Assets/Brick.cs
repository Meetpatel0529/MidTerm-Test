using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hitsRequired = 1; // Bricks break after 1 hit

    void OnCollisionEnter2D(Collision2D collision)
    {
        hitsRequired--;

        if (hitsRequired <= 0)
        {
            Destroy(gameObject);
        }
    }
}
