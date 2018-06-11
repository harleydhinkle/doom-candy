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
    private float timer;
    public float normaltime = 3;
    public player_movment owner;
    public GunUI play;
    public int points;
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
        if (owner.currentclip == 0)
        {
            reload2();
            controller.reload = true;
        }
        if (owner.currentclip >= 0&& controller.reload == false && controller.firegun == true)
        {
            owner.currentclip -= 1;
            owner.play.ammo2();
            //controller.player3.SetBool("fire", true);
            ray();
        }
            if (controller.reloadgun == true)
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
                target.takeDamage(damige,points,owner.GetComponent<player_movment>());
            }
            
        }
    }
    public void reload2()
    {
        int ammoiwant = owner.maxclip - owner.currentclip;
        int ammoiget = Mathf.Clamp(ammoiwant, 0, owner.currentaimo);
        owner.currentaimo -= ammoiget;
        owner.currentclip += ammoiget;
        play.ammo2();
    }
}
