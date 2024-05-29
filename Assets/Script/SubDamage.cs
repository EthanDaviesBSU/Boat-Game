using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubDamage : MonoBehaviour
{

    public Slider healthSlider;
    public static float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = ShipStats.subHealth;
        healthSlider.value = ShipStats.subHealth;
        currentHealth = ShipStats.subHealth;
        Debug.Log(ShipStats.subHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = currentHealth;
        if (currentHealth <= 0)
        {
            // ship death scene
            // make sure to reset ship stats
            SceneManager.LoadSceneAsync(3);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fish")
        {
            currentHealth -= 10f;
            collision.gameObject.SetActive(false);
            Debug.Log("Hull Health: " + ShipStats.subHealth);
        }
    }
}
