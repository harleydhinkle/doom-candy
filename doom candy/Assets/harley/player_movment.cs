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
    public int narmolhealth;
    public int currenthealth;
    public int maxhealth;
    //public Vector3 curlook;
    //public Vector3 predlook;
    //public Vector3 dir;
    // Use this for initialization
    void Start () {
        rm = GetComponent<Rigidbody>();
        currenthealth = narmolhealth;
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
    public void takeDamage(int damageTaken)
    {
        currenthealth -= damageTaken;
        if (currenthealth <= 0)
        {
            respawn();
        }
    }
    void respawn()
    {
        currenthealth = narmolhealth;
    }
}
