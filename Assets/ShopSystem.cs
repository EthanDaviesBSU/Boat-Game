using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ShopSystem : MonoBehaviour
{

    public Button healthButton, maxBatteryButton, maxOxygenButton, oxygenRegenButton, oxygenDecayButton, 
        moveSpeedButton, spotlightButton, auraButton, moneyMultiplierButton;

    public Button diveButton, exitButton;

    public int healthLvlMax = 10, maxBatteryLvlMax = 10, maxOxygenLvlMax = 10, oxygenRegenLvlMax = 5, oxygenDecayLvlMax = 5,
        moveSpeedLvlMax = 5, spotlightLvlMax = 5, auraLvlMax = 5, moneyMultiplierLvlMax = 5;

    public TMP_Text healthLvlText, maxBatteryLvlText, maxOxygenLvlText, oxygenRegenLvlText, oxygenDecayLvlText,
        moveSpeedLvlText, spotlightLvlText, auraLvlText, moneyMultiplierLvlText;

    public TMP_Text totalMoneyText;

    // Start is called before the first frame update
    void Start()
    {
        healthButton.onClick.AddListener(health);
        maxBatteryButton.onClick.AddListener(battery);
        maxOxygenButton.onClick.AddListener(oxygen);
        oxygenRegenButton.onClick.AddListener(regen);
        oxygenDecayButton.onClick.AddListener(decay);
        moveSpeedButton.onClick.AddListener(speed);
        spotlightButton.onClick.AddListener(spotlight);
        auraButton.onClick.AddListener(aura);
        moneyMultiplierButton.onClick.AddListener(money);
        diveButton.onClick.AddListener(dive);
        exitButton.onClick.AddListener(closeGame);
        healthLvlText.text = ShipStats.healthLvl + " / " + healthLvlMax;
        maxBatteryLvlText.text = ShipStats.maxBatteryLvl + " / " + maxBatteryLvlMax;
        maxOxygenLvlText.text = ShipStats.maxOxygenLvl + " / " + maxOxygenLvlMax;
        oxygenRegenLvlText.text = ShipStats.oxygenRegenLvl + " / " + oxygenRegenLvlMax;
        oxygenDecayLvlText.text = ShipStats.oxygenDecayLvl + " / " + oxygenDecayLvlMax;
        moveSpeedLvlText.text = ShipStats.moveSpeedLvl + " / " + moveSpeedLvlMax;
        spotlightLvlText.text = ShipStats.spotlightLvl + " / " + spotlightLvlMax;
        auraLvlText.text = ShipStats.auraLvl + " / " + auraLvlMax;
        moneyMultiplierLvlText.text = ShipStats.moneyMultiplierLvl + " / " + moneyMultiplierLvlMax;
        totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void health()
    {
        if (ShipStats.healthLvl != healthLvlMax && (ShipStats.totalMoney - 50) >= 0)
        {
            ShipStats.subHealth += 10f;
            ShipStats.healthLvl++;
            healthLvlText.text = ShipStats.healthLvl + " / " + healthLvlMax;
            ShipStats.totalMoney -= 50f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.subHealth);
        }
    }

    void battery()
    {
        if (ShipStats.maxBatteryLvl != maxBatteryLvlMax && (ShipStats.totalMoney - 50) >= 0)
        {
            ShipStats.maxBattery += 10f;
            ShipStats.maxBatteryLvl++;
            maxBatteryLvlText.text = ShipStats.maxBatteryLvl + " / " + maxBatteryLvlMax;
            ShipStats.totalMoney -= 50f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.maxBattery);
        }
    }

    void oxygen()
    {
        if (ShipStats.maxOxygenLvl != maxOxygenLvlMax && (ShipStats.totalMoney - 50) >= 0)
        {
            ShipStats.maxOxygen += 10f;
            ShipStats.maxOxygenLvl++;
            maxOxygenLvlText.text = ShipStats.maxOxygenLvl + " / " + maxOxygenLvlMax;
            ShipStats.totalMoney -= 50f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.maxOxygen);
        }
    }

    void regen()
    {
        if (ShipStats.oxygenRegenLvl != oxygenRegenLvlMax && (ShipStats.totalMoney - 100) >= 0)
        {
            ShipStats.oxygenRegen += 10f;
            ShipStats.oxygenRegenLvl++;
            oxygenRegenLvlText.text = ShipStats.oxygenRegenLvl + " / " + oxygenRegenLvlMax;
            ShipStats.totalMoney -= 100f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.oxygenRegen);
        }
    }

    void decay()
    {
        if (ShipStats.oxygenDecayLvl != oxygenDecayLvlMax && (ShipStats.totalMoney - 100) >= 0)
        {
            ShipStats.oxygenDecay += 10f;
            ShipStats.oxygenDecayLvl++;
            oxygenDecayLvlText.text = ShipStats.oxygenDecayLvl + " / " + oxygenDecayLvlMax;
            ShipStats.totalMoney -= 100f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.oxygenDecay);
        }
    }

    void speed()
    {
        if (ShipStats.moveSpeedLvl != moveSpeedLvlMax && (ShipStats.totalMoney - 200) >= 0)
        {
            ShipStats.moveSpeed += 100f;
            ShipStats.limitVelocity += 1f;
            ShipStats.moveSpeedLvl++;
            moveSpeedLvlText.text = ShipStats.moveSpeedLvl + " / " + moveSpeedLvlMax;
            ShipStats.totalMoney -= 200f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.moveSpeed);
        }
    }

    void spotlight()
    {
        if (ShipStats.spotlightLvl != spotlightLvlMax && (ShipStats.totalMoney - 200) >= 0)
        {
            ShipStats.spotlightRange += 2f;
            ShipStats.spotlightLvl++;
            spotlightLvlText.text = ShipStats.spotlightLvl + " / " + spotlightLvlMax;
            ShipStats.totalMoney -= 200f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.spotlightRange);
        }
    }

    void aura()
    {
        if (ShipStats.auraLvl != auraLvlMax && (ShipStats.totalMoney - 200) >= 0)
        {
            ShipStats.auraRange += 1f;
            ShipStats.auraLvl++;
            auraLvlText.text = ShipStats.auraLvl + " / " + auraLvlMax;
            ShipStats.totalMoney -= 200f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.auraRange);
        }
    }

    void money()
    {
        if (ShipStats.moneyMultiplierLvl != moneyMultiplierLvlMax && (ShipStats.totalMoney - 500) >= 0)
        {
            ShipStats.moneyMultiplier += 0.1f;
            ShipStats.moneyMultiplierLvl++;
            moneyMultiplierLvlText.text = ShipStats.moneyMultiplierLvl + " / " + moneyMultiplierLvlMax;
            ShipStats.totalMoney -= 500f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.moneyMultiplier);
        }
    }

    void dive()
    {
        SceneManager.LoadSceneAsync(2);
    }

    void closeGame()
    {
        Application.Quit();;
    }
}
