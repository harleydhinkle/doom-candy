using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class stopmenow : MonoBehaviour {
    public GameObject me;
    public void manu()
    {
        gamemaniger.GM.pose = false;
        SceneManager.LoadScene("MainMenu");
    }
    public void game()
    {
        me.SetActive(false);
        gamemaniger.GM.pose = false;
    }
}
