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

    private int healthLvl = 0, maxBatteryLvl = 0, maxOxygenLvl = 0, oxygenRegenLvl = 0, oxygenDecayLvl = 0, moveSpeedLvl = 0,
        spotlightLvl = 0, auraLvl = 0, moneyMultiplierLvl = 0;

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
        healthLvlText.text = healthLvl + " / " + healthLvlMax;
        maxBatteryLvlText.text = maxBatteryLvl + " / " + maxBatteryLvlMax;
        maxOxygenLvlText.text = maxOxygenLvl + " / " + maxOxygenLvlMax;
        oxygenRegenLvlText.text = oxygenRegenLvl + " / " + oxygenRegenLvlMax;
        oxygenDecayLvlText.text = oxygenDecayLvl + " / " + oxygenDecayLvlMax;
        moveSpeedLvlText.text = moveSpeedLvl + " / " + moveSpeedLvlMax;
        spotlightLvlText.text = spotlightLvl + " / " + spotlightLvlMax;
        auraLvlText.text = auraLvl + " / " + auraLvlMax;
        moneyMultiplierLvlText.text = moneyMultiplierLvl + " / " + moneyMultiplierLvlMax;
        totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void health()
    {
        if (healthLvl != healthLvlMax && (ShipStats.totalMoney - 50) >= 0)
        {
            ShipStats.subHealth += 10f;
            healthLvl++;
            healthLvlText.text = healthLvl + " / " + healthLvlMax;
            ShipStats.totalMoney -= 50f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.subHealth);
        }
    }

    void battery()
    {
        if (maxBatteryLvl != maxBatteryLvlMax && (ShipStats.totalMoney - 50) >= 0)
        {
            ShipStats.maxBattery += 10f;
            maxBatteryLvl++;
            maxBatteryLvlText.text = maxBatteryLvl + " / " + maxBatteryLvlMax;
            ShipStats.totalMoney -= 50f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.maxBattery);
        }
    }

    void oxygen()
    {
        if (maxOxygenLvl != maxOxygenLvlMax && (ShipStats.totalMoney - 50) >= 0)
        {
            ShipStats.maxOxygen += 10f;
            maxOxygenLvl++;
            maxOxygenLvlText.text = maxOxygenLvl + " / " + maxOxygenLvlMax;
            ShipStats.totalMoney -= 50f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.maxOxygen);
        }
    }

    void regen()
    {
        if (oxygenRegenLvl != oxygenRegenLvlMax && (ShipStats.totalMoney - 100) >= 0)
        {
            ShipStats.oxygenRegen += 10f;
            oxygenRegenLvl++;
            oxygenRegenLvlText.text = oxygenRegenLvl + " / " + oxygenRegenLvlMax;
            ShipStats.totalMoney -= 100f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.oxygenRegen);
        }
    }

    void decay()
    {
        if (oxygenDecayLvl != oxygenDecayLvlMax && (ShipStats.totalMoney - 100) >= 0)
        {
            ShipStats.oxygenDecay += 10f;
            oxygenDecayLvl++;
            oxygenDecayLvlText.text = oxygenDecayLvl + " / " + oxygenDecayLvlMax;
            ShipStats.totalMoney -= 100f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.oxygenDecay);
        }
    }

    void speed()
    {
        if (moveSpeedLvl != moveSpeedLvlMax && (ShipStats.totalMoney - 200) >= 0)
        {
            ShipStats.moveSpeed += 100f;
            ShipStats.limitVelocity += 1f;
            moveSpeedLvl++;
            moveSpeedLvlText.text = moveSpeedLvl + " / " + moveSpeedLvlMax;
            ShipStats.totalMoney -= 200f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.moveSpeed);
        }
    }

    void spotlight()
    {
        if (spotlightLvl != spotlightLvlMax && (ShipStats.totalMoney - 200) >= 0)
        {
            ShipStats.spotlightRange += 2f;
            spotlightLvl++;
            spotlightLvlText.text = spotlightLvl + " / " + spotlightLvlMax;
            ShipStats.totalMoney -= 200f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.spotlightRange);
        }
    }

    void aura()
    {
        if (auraLvl != auraLvlMax && (ShipStats.totalMoney - 200) >= 0)
        {
            ShipStats.auraRange += 1f;
            auraLvl++;
            auraLvlText.text = auraLvl + " / " + auraLvlMax;
            ShipStats.totalMoney -= 200f;
            totalMoneyText.text = "Money: £ " + ShipStats.totalMoney.ToString("0");
            Debug.Log(ShipStats.auraRange);
        }
    }

    void money()
    {
        if (moneyMultiplierLvl != moneyMultiplierLvlMax && (ShipStats.totalMoney - 500) >= 0)
        {
            ShipStats.moneyMultiplier += 0.1f;
            moneyMultiplierLvl++;
            moneyMultiplierLvlText.text = moneyMultiplierLvl + " / " + moneyMultiplierLvlMax;
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
