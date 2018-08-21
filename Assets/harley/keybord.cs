using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keybord : MonoBehaviour {
    public gamemaniger game;
    public Toggle trigger;
    void Start()
    {
        game = FindObjectOfType<gamemaniger>();
    }
        public void keybords ()
    {
        game.keybordcontrols = !game.keybordcontrols;
        if(game.keybordcontrols == true)
        {
            trigger.isOn = true;
        }
        if(game.keybordcontrols == false)
        {
            trigger.isOn = false;
        }
    }
}
