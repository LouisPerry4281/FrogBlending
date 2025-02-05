using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHealth : MonoBehaviour
{
    BlenderData blenderData;

    [SerializeField] float health = 3;

    public bool isInsideBlender = false;

    private void Start()
    {
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
        }
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
