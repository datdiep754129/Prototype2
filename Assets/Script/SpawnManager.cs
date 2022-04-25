using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       /** if (Input.GetKeyDown(KeyCode.J))
        {
            SpawnRandomAnimal();
        }
       **/
    }

    void SpawnRandomAnimal()
    {
        //Random range to generate animals
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        // Random Prefabs
        animalIndex = Random.Range(0, animalPrefabs.Length);
        // Spawn Prefabs
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
