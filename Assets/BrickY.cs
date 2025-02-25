using UnityEngine;

public class BrickY : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private int hitCount;

    private Color blue = new Color(0x0F / 255f, 0x0C / 255f, 0x98 / 255f);  // Custom blue
    private Color green = new Color(0x35 / 255f, 0x5B / 255f, 0x06 / 255f); // Custom green
    private Color yellow = new Color(0xB9 / 255f, 0x8D / 255f, 0x22 / 255f); // Custom yellow

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = yellow; // Initial color
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            hitCount++;
            UpdateBrickState();

        }
    }

    private void UpdateBrickState()
    {
        if (hitCount == 1)
        {
            spriteRenderer.color = blue;  // Yellow → Blue
        }
        else if (hitCount == 2)
        {
            spriteRenderer.color = green; // Blue → Green
        }
        else if (hitCount >= 3)
        {
            Destroy(gameObject); // Green → Disappear
        }
    }
}
