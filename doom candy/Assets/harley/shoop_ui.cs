using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shoop_ui : MonoBehaviour {

    public Text shop;
    void Start()
    {
        shop.text = "Press A to open the shop";
    }
    public void shoptext()
    {
        shop.text = "Press A to open the shop";
    }
}
