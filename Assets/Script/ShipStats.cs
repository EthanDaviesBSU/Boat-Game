using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour
{
    public static float maxBattery = 200f;
    public static float batteryDecay = 2f;
    public static float moveSpeed = 1000f;
    public static float limitVelocity = 10f;
    public static float oxygenDecay = 5f;
    public static float oxygenRegen = 5f;
    public static float maxOxygen = 100f;
    public static float moneyMultiplier = 1f;
    public static float subHealth = 100f;
    public static float spotlightRange = 15f;
    public static float auraRange = 4f;
    public static float totalMoney = 0f;
    public static float overallMoney = 0f;

    public static int healthLvl = 0, maxBatteryLvl = 0, maxOxygenLvl = 0, oxygenRegenLvl = 0, oxygenDecayLvl = 0, moveSpeedLvl = 0,
        spotlightLvl = 0, auraLvl = 0, moneyMultiplierLvl = 0;
}
