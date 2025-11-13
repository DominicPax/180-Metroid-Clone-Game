using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Dominic Paxson
 * 11/10/25
 * Handles the End Screen mechanics
 */

public class EndScreen : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        print("Quit Game");
    }

    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    
}
