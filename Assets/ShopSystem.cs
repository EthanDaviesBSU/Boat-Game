using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSystem : MonoBehaviour
{

    public Button healthButton, maxBatteryButton, maxOxygenButton, oxygenRegenButton, oxygenDecayButton, 
        moveSpeedButton, spotlightButton, auraButton, moneyMultiplierButton;

    private int healthLvl = 0, maxBatteryLvl = 0, maxOxygenLvl = 0, oxygenRegenLvl = 0, oxygenDecayLvl = 0, moveSpeedLvl = 0,
        spotlightLvl = 0, auraLvl = 0, moneyMultiplierLvl = 0;

    public int healthLvlMax = 10, maxBatteryLvlMax = 10, maxOxygenLvlMax = 10, oxygenRegenLvlMax = 5, oxygenDecayLvlMax = 5,
        moveSpeedLvlMax = 5, spotlightLvlMax = 5, auraLvlMax = 5, moneyMultiplierLvlMax = 5;

    public TMP_Text healthLvlText, maxBatteryLvlText, maxOxygenLvlText, oxygenRegenLvlText, oxygenDecayLvlText,
        moveSpeedLvlText, spotlightLvlText, auraLvlText, moneyMultiplierLvlText;

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
        healthLvlText.text = healthLvl + " / " + healthLvlMax;
        maxBatteryLvlText.text = maxBatteryLvl + " / " + maxBatteryLvlMax;
        maxOxygenLvlText.text = maxOxygenLvl + " / " + maxOxygenLvlMax;
        oxygenRegenLvlText.text = oxygenRegenLvl + " / " + oxygenRegenLvlMax;
        oxygenDecayLvlText.text = oxygenDecayLvl + " / " + oxygenDecayLvlMax;
        moveSpeedLvlText.text = moveSpeedLvl + " / " + moveSpeedLvlMax;
        spotlightLvlText.text = spotlightLvl + " / " + spotlightLvlMax;
        auraLvlText.text = auraLvl + " / " + auraLvlMax;
        moneyMultiplierLvlText.text = moneyMultiplierLvl + " / " + moneyMultiplierLvlMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void health()
    {
        if (healthLvl != healthLvlMax)
        {
            ShipStats.subHealth += 10f;
            healthLvl++;
            healthLvlText.text = healthLvl + " / " + healthLvlMax;
            Debug.Log(ShipStats.subHealth);
        }
    }

    void battery()
    {
        if (maxBatteryLvl != maxBatteryLvlMax)
        {
            ShipStats.maxBattery += 10f;
            maxBatteryLvl++;
            maxBatteryLvlText.text = maxBatteryLvl + " / " + maxBatteryLvlMax;
            Debug.Log(ShipStats.maxBattery);
        }
    }

    void oxygen()
    {
        if (maxOxygenLvl != maxOxygenLvl)
        {
            ShipStats.maxOxygen += 10f;
            maxOxygenLvl++;
            maxOxygenLvlText.text = maxOxygenLvl + " / " + maxOxygenLvlMax;
            Debug.Log(ShipStats.maxOxygen);
        }
    }

    void regen()
    {
        if (oxygenRegenLvl != oxygenRegenLvlMax)
        {
            ShipStats.oxygenRegen += 10f;
            oxygenRegenLvl++;
            oxygenRegenLvlText.text = oxygenRegenLvl + " / " + oxygenRegenLvlMax;
            Debug.Log(ShipStats.oxygenRegen);
        }
    }

    void decay()
    {
        if (oxygenDecayLvl != oxygenDecayLvlMax)
        {
            ShipStats.oxygenDecay += 10f;
            oxygenDecayLvl++;
            oxygenDecayLvlText.text = oxygenDecayLvl + " / " + oxygenDecayLvlMax;
            Debug.Log(ShipStats.oxygenDecay);
        }
    }

    void speed()
    {
        if (healthLvl != healthLvlMax)
        {
            ShipStats.subHealth += 10f;
            healthLvl++;
            healthLvlText.text = healthLvl + " / " + healthLvlMax;
            Debug.Log(ShipStats.subHealth);
        }
    }

    void spotlight()
    {
        if (healthLvl != healthLvlMax)
        {
            ShipStats.subHealth += 10f;
            healthLvl++;
            healthLvlText.text = healthLvl + " / " + healthLvlMax;
            Debug.Log(ShipStats.subHealth);
        }
    }

    void aura()
    {
        if (healthLvl != healthLvlMax)
        {
            ShipStats.subHealth += 10f;
            healthLvl++;
            healthLvlText.text = healthLvl + " / " + healthLvlMax;
            Debug.Log(ShipStats.subHealth);
        }
    }

    void money()
    {
        if (healthLvl != healthLvlMax)
        {
            ShipStats.subHealth += 10f;
            healthLvl++;
            healthLvlText.text = healthLvl + " / " + healthLvlMax;
            Debug.Log(ShipStats.subHealth);
        }
    }
}
