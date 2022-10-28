using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timeToSpawn = 5f;
    private float timeSinceSpawn;
    private ItemsPoolManager objectPool;
    [SerializeField] private GameObject[] prefab;
    [SerializeField] private float minX, maxX, minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        objectPool = FindObjectOfType<ItemsPoolManager>();
    }

    Vector3 GetSpawnPoint()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);

        return new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn >= timeToSpawn)
        {
            GameObject newItem = objectPool.GetObject(prefab[Random.Range(0, prefab.Length)]);
            newItem.transform.position = this.transform.position;
            timeSinceSpawn = 0f;
        }
    }
}
