using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammopickup : pickup {
    public int ammopickups;
    public float timer;

    void OnTriggerEnter(Collider other)
    {
     player_movment gun = other.GetComponent<player_movment>();
        if (gun != null)
        {
            pick.playfaceeffect(FaceStates.get);
            gun.currentaimo += ammopickups;
            gun.currentaimo = Mathf.Clamp(gun.currentaimo, 0, gun.maxaimo);
            play.ammo2();
            sp.currentpickups -= 1;
            Destroy(gameObject);
        }

    }
}
