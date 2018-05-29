using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseScript : MonoBehaviour
{
    //this is to manually set the price for the doors
    public int price;
    //this will be what it ends up as when the player buys a door
    public int change;

    player_movment buy;

    public void purchase()
    {
        change = buy.points - price;
        buy.points = change;
    }
}
