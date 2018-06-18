using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actuvat : MonoBehaviour {
    public GameObject enemys;
    public GameObject items;
    public void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Player1")
        {
            enemys.SetActive(true);
            items.SetActive(true);
        }
    }
}
