using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopTeleporter : MonoBehaviour
{

    private bool triggerActive;
    public GameObject interactPromptObject;

    // Start is called before the first frame update
    void Start()
    {
        triggerActive = false;
        interactPromptObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && triggerActive)
        {
            SceneManager.LoadSceneAsync(1);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        triggerActive = true;
        interactPromptObject.SetActive(true);

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        triggerActive = false;
        interactPromptObject.SetActive(false);
    }
}
