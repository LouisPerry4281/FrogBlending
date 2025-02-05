using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHealth : MonoBehaviour
{
    BlenderData blenderData;
    Rigidbody rb;

    [SerializeField] float health = 3;
    [SerializeField] float knockbackForce = 2000;

    public bool isInsideBlender = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        blenderData = FindObjectOfType<BlenderData>();
    }

    public void TakeDamage()
    {
        if (!isInsideBlender)
            return;

        health -= blenderData.blenderDamage; //Add multipliers here

        if (health <= 0)
        {
            FrogDeath();
            return;
        }

        rb.AddForce(Vector3.up * knockbackForce, ForceMode.Impulse);
    }

    private void FrogDeath()
    {
        Destroy(gameObject);
    }

    public void InitialiseFrog()
    {
        FindObjectOfType<FrogBlend>().blend.AddListener(TakeDamage);
    }
}
