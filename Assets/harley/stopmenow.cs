using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class stopmenow : MonoBehaviour {
    public GameObject me;
    public camracontrol look;
    public Slider xlook;
    public Slider ylook;
    void Start()
    {
        xlook.onValueChanged.AddListener(delegate { xlooknow(); });
        ylook.onValueChanged.AddListener(delegate { ylooknow(); });

    }
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
    public void xlooknow()
    {
        PlayerPrefs.SetFloat("xlook", xlook.value);
        look.mouseSensitivity_x = PlayerPrefs.GetFloat("xlook");
    }
    public void ylooknow()
    {
        PlayerPrefs.SetFloat("ylook", ylook.value);
        look.mouseSensitivity_y = PlayerPrefs.GetFloat("ylook");
    }
}
