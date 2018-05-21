using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour,IDamageable {
    public int health = 10;
    public float timer = 5;
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
    public void takeDamage(int damageTaken)
    {
        health -= damageTaken;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
       
        if(health<= 0)
        {
            die();
        }
    }
    void die()
    {
        Destroy(gameObject);
    }
}
