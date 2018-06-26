using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorUI : MonoBehaviour {

    public Text door;
    PurchaseScript price;

    private void Start()
    {
        price = FindObjectOfType<PurchaseScript>();
        door.text = "Press and hold A to buy door (" + price.price.ToString() + ")";
    }

    public void textdoor()
    {
        door.text = "Press and hold A to buy door (" + price.price.ToString() + ")"; 
    }
    
}
