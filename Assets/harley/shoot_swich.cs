using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public enum States3
{
    wandermap,
    seek,
    shoot
}
public class shoot_swich : MonoBehaviour {
    public NavMeshAgent agent;
    public States3 state;
    public float radius;
    enemywander wander;
    ememyseek seek;
    EnemyShoot shoot;
    public Animator yup;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        seek = GetComponent<ememyseek>();
        wander = GetComponent<enemywander>();
        shoot = GetComponent<EnemyShoot>();
        agent.Warp(transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        switch (state)
        {
            case States3.wandermap:
                agent.destination = transform.position + wander.wandercontol();
                agent.speed = wander.speed;
                agent.isStopped = false;
                break;
            case States3.shoot:
                agent.destination = seek.returnttargetspos();
                agent.updateRotation = true;
                if (Vector3.Distance(transform.position, seek.transform.position) <= 50)
                {
                    state = States3.wandermap;
                    yup.SetBool("hit", false);
                    agent.stoppingDistance = 0;
                    agent.isStopped = false;
                }
                break;
        }
        if (state == States3.wandermap)
        {
            swichstate();
        }

    }
    void swichstate()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in hitColliders)
        {
            if (hit.tag == "Player1" || hit.tag == "Player2")
            {
                state = States3.shoot;
                yup.SetBool("hit", true);
                //agent.isStopped = true;
                agent.stoppingDistance = 10f;
                seek.target = hit.transform;
                
            }



        }
    }
}
