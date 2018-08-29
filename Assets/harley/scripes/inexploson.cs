using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inexploson : MonoBehaviour {
    public float range;
	// Use this for initialization
	void Start () {
        players_in_exploson();

    }
	
	//// Update is called once per frame
	//void Update () {
      

 //   }
    void players_in_exploson()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, range);
        foreach (Collider hit in hitColliders)
        {
            var tamp = hit.gameObject.GetComponent<IDamageable>();
            if(tamp != null && hit.tag == "Player1")
            {
                tamp.takeDamage(10, 0, null);
            }

        }
    }
}
