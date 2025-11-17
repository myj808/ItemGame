
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform[] spawnPoints;
    public int itemCount = 10;

    void Start()
    {
        SpawnItems();
    }

    void SpawnItems()
    {
        for (int i = 0; i < itemCount; i++)
        {
            Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(itemPrefab, point.position, Quaternion.identity);
        }

        GameManager.Instance.SetTargetCount(10);
    }
}





