using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidSimulation : MonoBehaviour
{
    public Transform Ejector;

    public Rigidbody2D FluidPrefab;

    public float FluidAmount = 100;

    [Range(0.01f, 1f)] public float spawnDelay = 0.1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    [ContextMenu("Spawn Fluid")]
    public void SpawnFuild()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        for (int i = 0; i < FluidAmount; i++)
        {
            Vector2 randomForce = Random.insideUnitCircle;
            randomForce.y = -1;
            Instantiate(FluidPrefab, Ejector.position, Quaternion.identity, transform).AddForce(randomForce * 100);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
