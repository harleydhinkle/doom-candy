using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject buy;
    void OnTriggerEnter(Collider hit)
    {
        player_movment player = hit.GetComponent<player_movment>();
        if (hit.tag == "Player1" && player.controller.shop == true)
        {
            buy.SetActive(true);
        }
    }
}
