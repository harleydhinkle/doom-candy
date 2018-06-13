using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingai : MonoBehaviour {
    public Rigidbody fire;
    public float throwpower;
    public float radius;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void kill()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in hitColliders)
        {
            if (hit.tag == "Player1")
            {
                Rigidbody fire2 = Instantiate(fire, transform.position, transform.rotation) as Rigidbody;
                fire2.velocity = transform.position * throwpower;
            }



        }
    }
}
