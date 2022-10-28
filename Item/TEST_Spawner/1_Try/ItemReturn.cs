using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemReturn : MonoBehaviour
{
    private ItemsPoolManager objectPool;

    private void Start()
    {
        objectPool = FindObjectOfType<ItemsPoolManager>();
    }

    private void OnDisable()
    {
        if (objectPool != null)
            objectPool.ReturnGameObject(this.gameObject);
    }
}
