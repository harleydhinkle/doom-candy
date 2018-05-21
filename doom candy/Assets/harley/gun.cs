using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
    public int damige;
    public Camera camp;
    public controller controller;
    public float range = 100f;
    public LineRenderer line;
    public ParticleSystem gunflash;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (controller.firegun == true)
        {
            ray();
        }
    }
    void ray()
    {
        gunflash.Play();
        RaycastHit hit;
        if (Physics.Raycast(camp.transform.position, camp.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            NewBehaviourScript target = hit.transform.GetComponent<NewBehaviourScript>();
            if(target != null)
            {
                target.takeDamage(damige);
            }
            
        }
    }
}
