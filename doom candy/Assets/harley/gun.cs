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
    public int currentaimo;
    private int normalaimo = 10;
    private int maxaimo = 999;

    // Use this for initialization
    void Start () {
        currentaimo = normalaimo;
	}

    // Update is called once per frame
    void Update() {
        if (currentaimo <= 0)
        {
            currentaimo = normalaimo;
        }
        if (currentaimo >= 0)
        {
            if (controller.firegun == true)
            {
                currentaimo -= 1;
                ray();
            }
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
