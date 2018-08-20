using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keybord : MonoBehaviour {
    public void keybords ()
    {
        gamemaniger.GM.keybordcontrols = !gamemaniger.GM.keybordcontrols;
    }
}
