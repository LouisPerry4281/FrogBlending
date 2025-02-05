using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FrogBlend : MonoBehaviour
{
    [HideInInspector] public UnityEvent blend;
    [HideInInspector] public ButtonScript buttonScript;
    UpgradeSystem upgradeSystem;

    [SerializeField] float blendRefreshTimer;
    bool isReadyToBlend = true;

    private void Start()
    {
        buttonScript = FindObjectOfType<ButtonScript>();
        upgradeSystem = FindObjectOfType<UpgradeSystem>();
    }

    void Update()
    {
        if (buttonScript.isBlending && isReadyToBlend)
        {
            BlendFrog();
        } 
    }

    private void BlendFrog()
    {
        isReadyToBlend = false;

        blend.Invoke();

        Invoke(nameof(PrepareBlender), blendRefreshTimer * upgradeSystem.GetBlenderAttackRateMultiplier());
    }

    private void PrepareBlender()
    {
        isReadyToBlend = true;
    }
}
