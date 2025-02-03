using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSpawner : MonoBehaviour
{
    [SerializeField] GameObject eggnog;

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
}
