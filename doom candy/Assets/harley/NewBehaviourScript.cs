using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour,IDamageable {
    public int health = 10;
    public float timer = 5;
    public enemyspawnroom enemy3;
    public player_movment player1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            timer = 5;
        }
    }
    public void takeDamage(int damageTaken, int pointgain, player_movment player)
    {
        health -= damageTaken;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
       
        if(health<= 0)
        {
            die();
            player.points += pointgain;
        }
    }
    void die()
    {
        enemy3.currentanmontofenemys -= 1;
        Destroy(gameObject);
    }
    void OnCollisionStay(Collision hit)
    {
        var tamp = hit.gameObject.GetComponent<IDamageable>();
        player_movment player = hit.gameObject.GetComponent<player_movment>();
        if (tamp != null)
        {
            tamp.takeDamage(1, 0, player1);
        }
    }
}
