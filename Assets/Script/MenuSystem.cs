using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{

    public Button startButton;
    public Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartButton);
        exitButton.onClick.AddListener(ExitButton);
    }

    void StartButton()
    {
        InitialStats();
        SceneManager.LoadSceneAsync(1);
    }

    void ExitButton()
    {
        Application.Quit();
    }

    void InitialStats()
    {
        
    }
}
