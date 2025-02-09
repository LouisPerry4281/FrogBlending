using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    CurrencyData currencyData;

    [SerializeField] TextMeshProUGUI[] currencyUI;

    [SerializeField] GameObject mainUI, upgradeMenuUI;

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

    public void OpenUpgradeMenu()
    {
        mainUI.SetActive(false);
        upgradeMenuUI.SetActive(true);
    }

    public void OpenMainUI()
    {
        mainUI.SetActive(true);
        upgradeMenuUI.SetActive(false);
    }
}
