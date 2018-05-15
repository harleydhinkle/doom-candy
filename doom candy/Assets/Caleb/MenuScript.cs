using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("GameMode");
    }

    public void controls()
    {
        SceneManager.LoadScene("");
    }

    public void PvP()
    {
        SceneManager.LoadScene("");
    }

    public void Caracter()
    {
        SceneManager.LoadScene("");
    }

    public void PvE()
    {
        SceneManager.LoadScene("");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
