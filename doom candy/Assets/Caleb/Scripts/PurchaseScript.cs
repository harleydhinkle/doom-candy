using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseScript : MonoBehaviour
{
    //this is to manually set the price for the doors
    public int price;
    //this will be what it ends up as when the player buys a door
    public int change;
    public player_movment buy;
    public bool canbuy;
    public GameObject door2;
    public void purchase()
    {

        if (buy.controller.door == true)
        {
            change = buy.points -= price;
            buy.points = change;
            buy.play.score2();
            door2.SetActive(false);
        }
    }
}
