using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game Scene");
    }
    public void Learn()
    {
        SceneManager.LoadScene("Learn Scene");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu Screen");
    }
}
