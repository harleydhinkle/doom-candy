using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public int lives = 3;
    public int currentaimo;
    public int maxaimo = 999;
    //private float timer;
    public float normaltime = 3;
    public int maxclip = 10;
    public int currentclip;
    public GunUI play;
    public PlayerFaceUI do_do;
    public bool god;
    public int barrels;
    public GameObject havenolife;
    //public int money;
    //public Vector3 curlook;
    //public Vector3 predlook;
    //public Vector3 dir;
    // Use this for initialization
    void Start ()
    {
        rm = GetComponent<Rigidbody>();
        currenthealth = narmolhealth;
        owngun.owner = this;
        play.health2();
        play.ammo2();
        play.score2();
        lives = 3;
        owngun.play = play;
    }
	
	// Update is called once per frame
	void Update () {
        if(gamemaniger.GM.pose == true)
        {
            controller.horizontal = 0;
            controller.vertical = 0;
            rm.velocity = Vector3.zero;
            controller.player3.SetBool("walk", false);
            controller.player3.SetBool("fire", false);
            controller.player3.enabled = false;
            if(controller.gunoff == true)
            {
                controller.horizontal = 0;
                controller.vertical = 0;
                rm.velocity = Vector3.zero;
                controller.player4.SetBool("run", false);
                controller.player4.SetBool("hit", false);
                controller.player4.enabled = false;
            }
            return;
        }
        if(controller.gunoff == true)
        {
            controller.player4.enabled = true;
        }
        controller.player3.enabled = true;
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
        if(barrels == 4)
        {
            havenolife.SetActive(true);
        }
        
    }
    public void takeDamage(int damageTaken, int pointgain, player_movment player)
    {
        if(god == true)
        {
            return;
        }

        currenthealth -= damageTaken;
        do_do.playfaceeffect(FaceStates.damaged);
        play.health2();
        if (currenthealth <= 0)
        {
            respawn();
            lives -= 1;
            play.lives();
            player.points += pointgain;
        }
        if(lives <= 0)
        {
            SceneManager.LoadScene("Dead");
        }
        
    }
    void respawn()
    {
        currenthealth = narmolhealth;
    }
}
