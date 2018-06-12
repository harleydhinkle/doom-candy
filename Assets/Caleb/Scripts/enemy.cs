using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour, IDamageable
{

    public NavMeshAgent nav;
    public GameObject target;
    public int currentHealth;
    public int Maxhealth;
    public int attackDamage = 5;
    public int scoreAdded;
    // Use this for initialization
    void Start()
    {

        nav = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<player_movment>().gameObject;
    }

    public bool editor;
    void Update()
    {
        if (editor)
        {
            editor = false;
        }
        nav.destination = target.transform.position;
    }
    public void takeDamage(int damageTaken, int pointgain, player_movment player)
    {
        currentHealth -= damageTaken;
       
        if (currentHealth <= 0)
        {
            player.points += pointgain;
            die();
        }
    }
    public void die()
    {
        
            Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        IDamageable damage = other.gameObject.GetComponent<IDamageable>();
        if (damage != null)
        {
            damage.takeDamage(attackDamage,0,null);
        }
    }
}