using UnityEngine;
using System;
using System.Collections;

public class SpawnerSkeleton : MonoBehaviour
{
    public Rigidbody spawnObject;
    public Rigidbody spawnObjectPrefab;
    public float spawnTime = 1f;
    System.Random rnd = new System.Random();

    void Start()
    {
        int Quantity = rnd.Next(1, 18);
        for (int i = 0; i < Quantity; i++)
        {
            spawnObject = Instantiate(spawnObjectPrefab, transform.position + new Vector3(UnityEngine.Random.Range(-875f, -797f), 50f, UnityEngine.Random.Range(-500f, 360f)), Quaternion.identity);
        }
    }
}