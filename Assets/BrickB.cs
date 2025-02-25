using UnityEngine;

public class BrickB : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private int hitCount = 0; // Start at 0

    private Color blue = new Color(0x0F / 255f, 0x0C / 255f, 0x98 / 255f);  // Custom blue
    private Color green = new Color(0x35 / 255f, 0x5B / 255f, 0x06 / 255f); // Custom green

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetColor();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick")) 
        {
            hitCount++;
            UpdateBrickState();
        }
    }

    private void SetColor()
    {
        if (hitCount == 0) spriteRenderer.color = blue;
        else if (hitCount == 1) spriteRenderer.color = green;
    }

    private void UpdateBrickState()
    {
        if (hitCount == 1)
        {
            spriteRenderer.color = green; // Blue → Green
        }
        else if (hitCount >= 2)
        {
            Destroy(gameObject); // Green → Disappear
        }
    }
}
