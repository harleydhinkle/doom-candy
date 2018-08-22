using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keybord : MonoBehaviour {
    public gamemaniger game;
    public Toggle trigger;
    public GameObject keyboards;
    void Start()
    {
        game = FindObjectOfType<gamemaniger>();
        refreshUI();
    }

    public void refreshUI()
    {
        if (game.keybordcontrols == true)
        {
            trigger.isOn = true;
            keyboards.SetActive(true);
        }
        if (game.keybordcontrols == false)
        {
            trigger.isOn = false;
            keyboards.SetActive(false);
        }
    }

    public void keybords (bool value)
    {
        game.keybordcontrols = value;
        refreshUI();
    }
}
