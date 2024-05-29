using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupTreasure : MonoBehaviour
{

    public BoxCollider2D player;
    public TMP_Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Treasure")
        {
            ShipStats.totalMoney += 50f * ShipStats.moneyMultiplier;
            ShipStats.overallMoney += 50f * ShipStats.moneyMultiplier;
            collision.gameObject.SetActive(false);
            Debug.Log(collision.tag + " Picked Up!");
            Debug.Log("Money: " + ShipStats.totalMoney);
        }
        if (collision.tag == "Big Treasure")
        {
            ShipStats.totalMoney += 100f * ShipStats.moneyMultiplier;
            ShipStats.overallMoney += 100f * ShipStats.moneyMultiplier;
            collision.gameObject.SetActive(false);
            Debug.Log(collision.tag + " Picked Up!");

        }
        moneyText.text = "£ " + ShipStats.totalMoney.ToString("0");
    }
}