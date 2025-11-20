
using UnityEngine;
using System.Collections.Generic;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform[] spawnPoints;
    public int itemCount = 10;

    private Queue<GameObject> itemPool = new Queue<GameObject>();

    void Start()
    {
        InitializePool();
        SpawnItems();
    }

    void InitializePool()
    {
        for (int i = 0; i < itemCount; i++)
        {
            GameObject item = Instantiate(itemPrefab);
            item.SetActive(false);
            itemPool.Enqueue(item);
        }
    }

    void SpawnItems()
    {
        for (int i = 0; i < itemCount; i++)
        {
            if (itemPool.Count > 0)
            {
                GameObject item = itemPool.Dequeue();
                Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
                item.transform.position = point.position;
                item.SetActive(true);
            }
        }

        GameManager.Instance.SetTargetCount(itemCount);
    }

    public void ReturnItemToPool(GameObject item)
    {
        item.SetActive(false);
        itemPool.Enqueue(item);
    }
}




