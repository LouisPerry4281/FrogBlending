using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSpawner : MonoBehaviour
{
    [SerializeField] GameObject eggnog;
    [SerializeField] float eggnogSpawnDelay;

    private void Start()
    {
        StartCoroutine(BasicFrogSpawner());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnFrog(eggnog);
        }
    }

    public void SpawnFrog(GameObject frogToSpawn)
    {
        Instantiate(frogToSpawn, transform.position, Quaternion.identity);
    }

    private IEnumerator BasicFrogSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(eggnogSpawnDelay);
            SpawnFrog(eggnog);
        }
    }
}
