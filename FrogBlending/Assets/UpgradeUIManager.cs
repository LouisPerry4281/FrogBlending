using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeUIManager : MonoBehaviour
{
    UpgradeSystem upgradeSystem;
    [SerializeField] TextMeshProUGUI[] upgradeButtonText;
    

    private void Start()
    {
        upgradeSystem = FindObjectOfType<UpgradeSystem>();
    }

    void Update()
    {
        UpdateUIButtons();
    }

    private void UpdateUIButtons()
    {
        //Look, this whole thing is pretty damn bad, but for the sake of fast implementation, it's fine for now.

        //SPAWN RATE
        if (upgradeSystem.spawnRateUpgradeLevel < upgradeSystem.spawnRateUpgrade.Length - 1)
        {
            upgradeButtonText[0].text = "Level " + (upgradeSystem.spawnRateUpgradeLevel + 1) + " : Cost " + upgradeSystem.spawnRateUpgradeCost[upgradeSystem.spawnRateUpgradeLevel]; //Spawn Rate Upgrade
        }
        else
        {
            upgradeButtonText[0].text = "Max Level";
        }

        //BLENDER DAMAGE
        if (upgradeSystem.blenderDamageUpgradeLevel < upgradeSystem.blenderDamageUpgrade.Length - 1)
        {
            upgradeButtonText[1].text = "Level " + (upgradeSystem.blenderDamageUpgradeLevel + 1) + " : Cost " + upgradeSystem.blenderDamageUpgradeCost[upgradeSystem.blenderDamageUpgradeLevel]; //Blender Damage Upgrade
        }
        else
        {
            upgradeButtonText[1].text = "Max Level";
        }

        //BLENDER ATTACK RATE
        if (upgradeSystem.blenderAttackRechargeUpgradeLevel < upgradeSystem.blenderAttackRechargeUpgrade.Length - 1)
        {
            upgradeButtonText[2].text = "Level " + (upgradeSystem.blenderAttackRechargeUpgradeLevel + 1) + " : Cost " + upgradeSystem.blenderAttackRechargeCost[upgradeSystem.blenderAttackRechargeUpgradeLevel]; //Blender Attack Rate Upgrade
        }
        else
        {
            upgradeButtonText[2].text = "Max Level";
        }

    }
}
