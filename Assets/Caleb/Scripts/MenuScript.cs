using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    //delay allows for the button sounds to play before moving scenes.
    public float Delay;
    float t = 0;
    public void StartGame()
    {
        StartCoroutine(DelayLevel("Map_2"));
        gamemaniger.GM.pose = false;
    }

    public void controls()
    {
        StartCoroutine(DelayLevel("ControlsMenu"));
    }

    public void PvP()
    {

            SceneManager.LoadScene("");

    }

    public void Character()
    {
    
            SceneManager.LoadScene("");

    }

    public void PvE()
    {

            SceneManager.LoadScene("");

    }

    public void MainMenu()
    {
        StartCoroutine(DelayLevel("MainMenu"));

    }

    public void QuitGame()
    {
 
            Application.Quit();

    }

    public void Credits()
    {
        StartCoroutine(DelayLevel("Credits")); 
    }


    IEnumerator DelayLevel(string levelname)
    {
        yield return new WaitForSeconds(.3f);
        SceneManager.LoadScene(levelname);
    }
}
