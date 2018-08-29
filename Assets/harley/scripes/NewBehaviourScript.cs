using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour,IDamageable {
    public int health = 10;
    public float timer = 5;
    public enemyspawnroom enemy3;
    public player_movment player1;
    public int Points;
    public int damige;
    public GunUI play;
    public GameObject pow;
    public Animator a;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
         
            timer = 5;
        }
    }
    public void takeDamage(int damageTaken, int pointgain, player_movment player)
    {
        health -= damageTaken;
     
       
        if(health<= 0)
        {
            var spawnBaby = Instantiate(pow);
            spawnBaby.transform.position = transform.position;
            die();
            player.points += pointgain + Points;
            play.score2();
           
            
        }
    }
    void die()
    {
        enemy3.currentanmontofenemys -= 1;
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision hit)
    {
        var tamp = hit.gameObject.GetComponent<IDamageable>();
        if (tamp != null)
        {
            tamp.takeDamage(damige, 0, player1);
            a.SetBool("hit", true);
        }
    }
    void OnCollisionExit(Collision hit)
    {
        var tamp = hit.gameObject.GetComponent<IDamageable>();
        if (tamp != null)
        {
            a.SetBool("hit", false);
        }
    }
}
