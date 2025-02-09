using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FrogHealth : MonoBehaviour
{
    BlenderData blenderData;
    Rigidbody rb;
    UIManager uIManager;
    CurrencyData currencyData;
    UpgradeSystem upgradeSystem;

    [SerializeField] GameObject deathParticles;
    [SerializeField] GameObject coinGainedText;

    [SerializeField] float health = 3;
    [SerializeField] float knockbackForce = 2000;

    [SerializeField] int currencyDropped;

    public bool isInsideBlender = false;

    private void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        rb = GetComponent<Rigidbody>();
        blenderData = FindObjectOfType<BlenderData>();
        currencyData = FindObjectOfType<CurrencyData>();
        upgradeSystem = FindObjectOfType<UpgradeSystem>();
    }

    public void TakeDamage()
    {
        if (!isInsideBlender)
            return;

        health -= blenderData.blenderDamage * upgradeSystem.GetBlenderDamageMultiplier(); //Add multipliers here

        if (health <= 0)
        {
            FrogDeath();
            return;
        }

        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        rb.AddForce(Vector3.up * knockbackForce, ForceMode.Impulse);
    }

    private void FrogDeath()
    {
        currencyData.AddCurrency(currencyDropped);
        uIManager.UpdateCurrency();

        GameObject coinGainedTextInstance = Instantiate(coinGainedText, transform.position, Quaternion.identity);
        coinGainedTextInstance.GetComponentInChildren<TextMeshProUGUI>().text = "+" + currencyDropped + " FrogCoins";

        GameObject deathParticlesInstance = Instantiate(deathParticles, transform.position, Quaternion.identity);
        deathParticlesInstance.GetComponent<ParticleSystem>().Play();

        Destroy(gameObject);
    }

    public void InitialiseFrog()
    {
        FindObjectOfType<FrogBlend>().blend.AddListener(TakeDamage);
    }
}
