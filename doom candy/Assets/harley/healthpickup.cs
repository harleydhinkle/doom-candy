using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpickup : pickup{
    public float healthpickups;
    public float timer;
    // Use this for initialization
    void Start () {
        timer = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        player_movment player = other.GetComponent<player_movment>();
        if (player != null)
        {
            player.currenthealth += healthpickups;
            player.currenthealth = Mathf.Clamp(player.currenthealth, 0, player.maxhealth);
            sp.currentpickups -= 1;
            Destroy(gameObject);
        }

    }
}
