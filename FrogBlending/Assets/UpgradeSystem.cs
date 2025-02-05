using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    CurrencyData currencyData;

    [Header("Frog Spawn Rate Upgrades")]
    public int spawnRateUpgradeLevel = 0;
    public float[] spawnRateUpgrade; //Lower is better
    public int[] spawnRateUpgradeCost; 

    [Header("Blender Damage Upgrades")]
    public int blenderDamageUpgradeLevel = 0;
    public float[] blenderDamageUpgrade;
    public int[] blenderDamageUpgradeCost;

    [Header("Blender Attack Rate Upgrades")]
    public int blenderAttackRechargeUpgradeLevel = 0;
    public float[] blenderAttackRechargeUpgrade; //Lower is better
    public int[] blenderAttackRechargeCost; 

    public float GetFrogSpawnRateMultiplier()
    {
        float multiplier = spawnRateUpgrade[spawnRateUpgradeLevel];
        return multiplier;
    }

    public void IncreaseFrogSpawnRate()
    {
        if (currencyData.currency < spawnRateUpgradeCost[spawnRateUpgradeLevel])
        {
            return;
        }
        currencyData.SpendCurrency(spawnRateUpgradeCost[spawnRateUpgradeLevel]);
        spawnRateUpgradeLevel++;
    }

    public float GetBlenderDamageMultiplier()
    {
        float multiplier = blenderDamageUpgrade[blenderDamageUpgradeLevel];
        return multiplier;
    }

    public void IncreaseBlenderDamage()
    {
        if (currencyData.currency < blenderDamageUpgradeCost[blenderDamageUpgradeLevel])
        {
            return;
        }
        currencyData.SpendCurrency(blenderDamageUpgradeCost[blenderDamageUpgradeLevel]);
        blenderDamageUpgradeLevel++;
    }

    public float GetBlenderAttackRateMultiplier()
    {
        float multiplier = blenderAttackRechargeUpgrade[blenderAttackRechargeUpgradeLevel];
        return multiplier;
    }

    public void IncreaseBlenderAttackRate()
    {
        if (currencyData.currency < blenderAttackRechargeCost[blenderAttackRechargeUpgradeLevel])
        {
            return;
        }
        currencyData.SpendCurrency(blenderAttackRechargeCost[blenderAttackRechargeUpgradeLevel]);
        blenderAttackRechargeUpgradeLevel++;
    }

    private void Start()
    {
        currencyData = FindObjectOfType<CurrencyData>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            IncreaseFrogSpawnRate();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            IncreaseBlenderDamage();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            IncreaseBlenderAttackRate();
        }
    }
}
