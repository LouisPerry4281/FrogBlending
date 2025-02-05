using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyData : MonoBehaviour
{
    public int currency = 0;

    public void AddCurrency(int currencyToAdd)
    {
        currency += currencyToAdd;
    }
}
