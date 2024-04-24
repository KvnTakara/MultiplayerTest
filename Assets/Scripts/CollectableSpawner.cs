using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    #region Variables

    [SerializeField] GameObject collectablePrefab;

    [SerializeField] int collectableAmount;

    [SerializeField] Vector3 spawnArea;
    [SerializeField] Vector3 spawnCenter;

    Vector3 spawnedPosition;

    #endregion

    #region Initialization

    void Start()
    {
        for (int i = 0; i < collectableAmount; i++)
        {
            InstantiateCollectables();
        }
    }

    #endregion

    #region Functions

    void InstantiateCollectables()
    {
        float spawnPositionX = spawnArea.x * 0.5f + spawnCenter.x;
        float spawnPositionY = spawnArea.y;
        float spawnPositionZ = spawnArea.z * 0.5f + spawnCenter.z;

        spawnedPosition = new Vector3(Random.Range(-spawnPositionX, spawnPositionX), spawnPositionY, Random.Range(-spawnPositionZ, spawnPositionZ));

        GameObject collectableInstance = Instantiate(collectablePrefab, spawnedPosition, Quaternion.identity);
    }

    #endregion
}
