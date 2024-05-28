using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSystem : MonoBehaviour
{

    public Button healthButton, maxBatteryButton, maxOxygenButton, oxygenRegenButton, oxygenDecayButton, 
        moveSpeedButton, spotlightButton, auraButton, moneyMultiplierButton;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void health()
    {
        ShipStats.subHealth += 10f;
    }

    void battery()
    {

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
