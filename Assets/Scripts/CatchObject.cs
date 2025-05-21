using UnityEngine;

public class CatchObject : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 10f); // Auto-cleanup after 10 seconds
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(1); // add 1 point
            Destroy(gameObject);
        }
        else if (other.CompareTag("Ground"))
        {
            GameOverManager.Instance.Miss(); // we'll add this next
            Destroy(gameObject);
        }
    }

}
