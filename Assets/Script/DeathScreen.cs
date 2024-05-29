using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DeathScreen : MonoBehaviour
{

    public Button exitButton;
    public Button continueButton;
    public TMP_Text finalMoney;


    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(ExitButton);
        continueButton.onClick.AddListener(ContinueButton);
        finalMoney.text = "You Earned: £" + ShipStats.overallMoney.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void ExitButton()
    {
        Application.Quit();
    }

    void ContinueButton()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
