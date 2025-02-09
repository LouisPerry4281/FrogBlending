using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyData : MonoBehaviour
{
    UIManager uIManager;

    public int currency = 0;

    public void AddCurrency(int currencyToAdd)
    {
        currency += currencyToAdd;
        uIManager.UpdateCurrency();
    }

    public void SpendCurrency(int currencyToSpend)
    {
        currency -= currencyToSpend;
        uIManager.UpdateCurrency();
    }

    private void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
    }
}
