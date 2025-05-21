using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveX * moveSpeed * Time.deltaTime);
    }
}
