using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;
    public float spawnInterval = 1.5f;
    public float xRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnInterval);
    }

    void SpawnObject()
    {
        float xHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
        float randomX = Random.Range(-xHalfWidth + 0.5f, xHalfWidth - 0.5f);
        Vector3 spawnPos = new Vector3(randomX, 6f, 0f);
        Instantiate(fallingObjectPrefab, spawnPos, Quaternion.identity);
    }
}
