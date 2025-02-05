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
        upgradeButtonText[0].text = "Level " + (upgradeSystem.spawnRateUpgradeLevel + 1); //Spawn Rate Upgrade
        upgradeButtonText[1].text = "Level " + (upgradeSystem.blenderDamageUpgradeLevel + 1); //Blender Damage Upgrade
        upgradeButtonText[2].text = "Level " + (upgradeSystem.blenderAttackRechargeUpgradeLevel + 1); //Blender Attack Rate Upgrade
    }
}
