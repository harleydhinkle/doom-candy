using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actuvat : MonoBehaviour {
    public GameObject enemys;
    public GameObject items;
    public GameObject lest_room_enemys;
    public GameObject lest_room_items;
    public GameObject stopshowing;
    public void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Player1")
        {
            enemys.SetActive(true);
            items.SetActive(true);
            lest_room_enemys.SetActive(false);
            lest_room_items.SetActive(false);
            stopshowing.SetActive(false);
        }
    }
}
