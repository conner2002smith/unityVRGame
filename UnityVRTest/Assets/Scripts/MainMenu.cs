using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// Switches scene to the game
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    /// Exits the application
    public void QuitGame()
    {
        Debug.Log("Exiting game!");
        Application.Quit();
    }
}