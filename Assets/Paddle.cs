using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 8f;
    public float boundary = 7f; // Restrict movement

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float newX = Mathf.Clamp(transform.position.x + move, -boundary, boundary);
        transform.position = new Vector3(newX, transform.position.y, 0);
    }
}
