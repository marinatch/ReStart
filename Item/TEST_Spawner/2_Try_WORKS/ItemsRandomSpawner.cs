using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsRandomSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] itemPrefab;
    [SerializeField] Transform parent;
    [SerializeField] private float secondsToSpawn = 10.0f;
    [SerializeField] private float minX, maxX, minY, maxY;

    private void Start()
    {
        StartCoroutine(ItemSpawner());
    }

    IEnumerator ItemSpawner()
    {
        while(true)
        {
            var ranX = Random.Range(minX, maxX);
            var ranY = Random.Range(minY, maxY);
            var position = new Vector3(ranX, ranY);
            GameObject gameObject = Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)], position, Quaternion.identity, parent);
            yield return new WaitForSeconds(secondsToSpawn);
            Destroy(gameObject, 500);
        }
    }
}
