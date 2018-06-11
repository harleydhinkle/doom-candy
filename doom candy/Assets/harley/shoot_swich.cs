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
                agent.isStopped = false;
                break;
            case States3.shoot:
                agent.destination = seek.returnttargetspos();
                if (Vector3.Distance(transform.position, seek.transform.position) <= 50)
                {
                    state = States3.wandermap;
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
                agent.isStopped = true;
                seek.target = hit.transform;
            }



        }
    }
}
