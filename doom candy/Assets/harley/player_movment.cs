using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movment : MonoBehaviour,IDamageable {
    public float speed;
    public controller controller;
    Vector3 desierv;
    float horizontal;
    float vertical;
    public Rigidbody rm;
    public Transform cam;
    public GameObject melee;
    public float narmolhealth;
    public float currenthealth;
    public float maxhealth;
    public gun owngun;
    public int points;
    public int currentaimo;
    public int maxaimo = 999;
    private float timer;
    public float normaltime = 3;
    public int maxclip = 10;
    public int currentclip;
    //public Vector3 curlook;
    //public Vector3 predlook;
    //public Vector3 dir;
    // Use this for initialization
    void Start ()
    {
        rm = GetComponent<Rigidbody>();
        currenthealth = narmolhealth;
        owngun.owner = this;
    }
	
	// Update is called once per frame
	void Update () {
        horizontal = controller.horizontal;
        Vector3 myright = cam.right * horizontal;
        vertical = controller.vertical;
        Vector3 myup = cam.forward * vertical;
        myright.y = 0;
        myup.y = 0;
        desierv = (myup + myright).normalized * speed * Time.deltaTime;
        rm.velocity = desierv;
        //if (controller.hit == true)
        //{
        //    GameObject melee2 = Instantiate(melee)as GameObject;
        //    melee2.transform.position = transform.forward;
        //    melee2.transform.position.y.Equals(90);
        
        //curlook = new Vector3(rm.velocity.x, 0, rm.velocity.z);

        //if (curlook == Vector3.zero)
        //{
        //    transform.forward = predlook;
        //}
        //else
        //{
        //    predlook = curlook;
        //    transform.forward = curlook;
        //}
        //if (horizontal == 0 && vertical == 0)
        //{

        //}
        //if (rm.velocity.magnitude > 1)
        //{
        //    dir = rm.velocity.normalized;
        //}

        
    }
    public void takeDamage(int damageTaken, int pointgain, player_movment player)
    {
        currenthealth -= damageTaken;
        if (currenthealth <= 0)
        {
            respawn();
            player.points += pointgain;
        }
    }
    void respawn()
    {
        currenthealth = narmolhealth;
    }
}
