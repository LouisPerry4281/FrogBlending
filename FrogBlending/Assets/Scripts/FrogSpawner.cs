using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSpawner : MonoBehaviour
{
    [SerializeField] GameObject eggnog;
    [SerializeField] float eggnogSpawnDelay;
    [SerializeField] Transform spawner;

    UpgradeSystem upgradeSystem;

    private void Start()
    {
        upgradeSystem = FindObjectOfType<UpgradeSystem>();

        StartCoroutine(BasicFrogSpawner());
    }

    public void SpawnFrog(GameObject frogToSpawn)
    {
        GameObject frogInstance = Instantiate(frogToSpawn, spawner.transform.position, Quaternion.identity);
        frogInstance.GetComponent<FrogHealth>().InitialiseFrog();
    }

    private IEnumerator BasicFrogSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(eggnogSpawnDelay * upgradeSystem.GetFrogSpawnRateMultiplier());
            SpawnFrog(eggnog);
        }
    }
}
