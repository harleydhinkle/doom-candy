using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bashballbat : MonoBehaviour {
    public player_movment owner;
    public int damige;
    void OnTriggerEnter(Collider other)
    {
        var think = other.GetComponent<IDamageable>();
        if (other.gameObject != owner)
        {
            if (think != null && other.tag == "enemy")
            {
                think.takeDamage(damige, 1, owner);
            }
        }
    }
}
