using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    CurrencyData currencyData;

    [SerializeField] TextMeshProUGUI[] currencyUI;

    private void Start()
    {
        currencyData = FindObjectOfType<CurrencyData>();
    }

    public void UpdateCurrency()
    {
        foreach(TextMeshProUGUI ui in currencyUI)
        {
            ui.text = "FrogCoin: " + currencyData.currency;
        }
    }
}
