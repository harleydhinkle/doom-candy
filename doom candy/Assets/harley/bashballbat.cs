using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bashballbat : MonoBehaviour {
    public GameObject owner;
    public int damige;
    void OnTriggerEnter(Collider other)
    {
        var think = other.GetComponent<IDamageable>();
        player_movment player = other.GetComponent<player_movment>();
        if (other.gameObject != owner)
        {
            if (think != null && other.tag == "enemy")
            {
                think.takeDamage(damige, 1, owner.GetComponent<player_movment>());
            }
        }
    }
}
