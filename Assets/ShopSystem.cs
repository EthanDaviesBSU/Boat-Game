using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSystem : MonoBehaviour
{

    public Button healthButton, maxBatteryButton, maxOxygenButton, oxygenRegenButton, oxygenDecayButton, 
        moveSpeedButton, spotlightButton, auraButton, moneyMultiplierButton;

    private int healthLvl = 1, maxBatteryLvl = 1, maxOxygenLvl = 1, oxygenRegenLvl = 1, oxygenDecayLvl = 1, moveSpeedLvl = 1,
        spotlightLvl = 1, auraLvl = 1, moneyMultiplierLvl = 1;

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
        maxBatteryLvlText.text = healthLvl + " / " + healthLvlMax;
        maxOxygenLvlText.text = healthLvl + " / " + healthLvlMax;
        oxygenRegenLvlText.text = healthLvl + " / " + healthLvlMax;
        oxygenDecayLvlText.text = healthLvl + " / " + healthLvlMax;
        moveSpeedLvlText.text = healthLvl + " / " + healthLvlMax;
        spotlightLvlText.text = healthLvl + " / " + healthLvlMax;
        auraLvlText.text = healthLvl + " / " + healthLvlMax;
        moneyMultiplierLvlText.text = healthLvl + " / " + healthLvlMax;
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
        }
    }

    void battery()
    {
        if (maxBatteryLvl != maxBatteryLvlMax)
        {
            ShipStats.maxBattery += 10f;
            maxBatteryLvl++;
        }
    }

    void oxygen()
    {

    }

    void regen()
    {

    }

    void decay()
    {

    }

    void speed()
    {

    }

    void spotlight()
    {

    }

    void aura()
    {

    }

    void money()
    {

    }
}
