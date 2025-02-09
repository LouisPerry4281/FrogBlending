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
        if (CheckUpgradeCost(spawnRateUpgradeCost[spawnRateUpgradeLevel]))
        {
            spawnRateUpgradeLevel++;
        }
    }

    public float GetBlenderDamageMultiplier()
    {
        float multiplier = blenderDamageUpgrade[blenderDamageUpgradeLevel];
        return multiplier;
    }

    public void IncreaseBlenderDamage()
    {
        if (CheckUpgradeCost(blenderDamageUpgradeCost[blenderDamageUpgradeLevel]))
        {
            blenderDamageUpgradeLevel++;
        }
    }

    public float GetBlenderAttackRateMultiplier()
    {
        float multiplier = blenderAttackRechargeUpgrade[blenderAttackRechargeUpgradeLevel];
        return multiplier;
    }

    public void IncreaseBlenderAttackRate()
    {
        if (CheckUpgradeCost(blenderAttackRechargeCost[blenderAttackRechargeUpgradeLevel]))
        {
            blenderAttackRechargeUpgradeLevel++;
        }
    }

    private bool CheckUpgradeCost(int cost)
    {
        if (currencyData.currency < cost)
        {
            print("Not Enough Moola");
            return false;
        }

        else
        {
            currencyData.SpendCurrency(cost);
            return true;
        }
    }

    private void Start()
    {
        currencyData = FindObjectOfType<CurrencyData>();
    }
}
