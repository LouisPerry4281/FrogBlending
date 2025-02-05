using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public int spawnRateUpgradeLevel = 0;
    public float[] spawnRateUpgrade; //Lower is better

    public int blenderDamageUpgradeLevel = 0;
    public float[] blenderDamageUpgrade;

    public int blenderAttackRechargeUpgradeLevel = 0;
    public float[] blenderAttackRechargeUpgrade; //Lower is better

    public float GetFrogSpawnRateMultiplier()
    {
        float multiplier = spawnRateUpgrade[spawnRateUpgradeLevel];
        return multiplier;
    }

    public float GetBlenderDamageMultiplier()
    {
        float multiplier = blenderDamageUpgrade[blenderDamageUpgradeLevel];
        return multiplier;
    }

    public float GetBlenderAttackRateMultiplier()
    {
        float multiplier = blenderAttackRechargeUpgrade[blenderAttackRechargeUpgradeLevel];
        return multiplier;
    }
}
