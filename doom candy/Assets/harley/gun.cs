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
    private int maxaimo = 999;
    private float timer;
    public float normaltime = 3;
    public int maxclip = 10;
    public int currentclip;
    // Use this for initialization
    void Start () {
	}

    // Update is called once per frame
    void Update()
    {
        if(controller.reload == true&& timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            controller.reload = false;
            timer = normaltime;
        }
        if (currentclip == 0)
        {
            reload2();
            controller.reload = true;
        }
        if (currentclip >= 0&& controller.reload == false && controller.firegun == true)
        {
            currentclip -= 1;
            ray();
        }
        if(controller.reloadgun == true)
        {
            controller.reload = true;
            reload2();
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
    public void reload2()
    {
        int ammoiwant = maxclip - currentclip;
        int ammoiget = Mathf.Clamp(ammoiwant, 0, currentaimo);
        currentaimo -= ammoiget;
        currentclip += ammoiget;
    }
}
