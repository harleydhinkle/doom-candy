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
            takeDamage(2);
        }
        nav.destination = target.transform.position;
    }
    public void takeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        die();
    }
    public void die()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        IDamageable damage = other.gameObject.GetComponent<IDamageable>();
        if (damage != null)
        {
            damage.takeDamage(attackDamage);
        }
    }
}