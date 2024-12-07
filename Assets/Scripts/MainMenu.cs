using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Button playButton;

    [SerializeField]
    private Button exitButton; 

    // Η μέθοδος Start καλείται όταν ξεκινάει το script
    void Start()
    {
        // Συνδέουμε το κουμπί playButton με τη μέθοδο PlayGame
        playButton.onClick.AddListener(PlayGame);

        // Συνδέουμε το κουμπί exitButton με τη μέθοδο ExitGame
        exitButton.onClick.AddListener(ExitGame);
    }

    // Μέθοδος που καλείται όταν πατηθεί το playButton
    public void PlayGame()
    {
        SceneManager.LoadScene("InstructionsScene"); 
    }

    // Μέθοδος που καλείται όταν πατηθεί το exitButton
    public void ExitGame()
    {
        // Κλείνουμε το παιχνίδι
        Application.Quit();

        // Στον Unity Editor, σταματάμε την εκτέλεση
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif

    }
}


