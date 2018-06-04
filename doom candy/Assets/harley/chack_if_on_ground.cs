using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chack_if_on_ground : MonoBehaviour {
    public bool isGrounded;
    public float hitdistance;
    public LayerMask layer;
    public float down;
    public player_movment player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UpdateStates();
	}
    public void UpdateStates()
    {
        if(isGrounded == true)
        {
            hitdistance = 0.35f;
        }
        else
        {
            hitdistance = 0.15f;
            player.rm.AddForce(Vector3.down * down);

        }
        if (Physics.Raycast(transform.position, -transform.up, hitdistance, layer))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
