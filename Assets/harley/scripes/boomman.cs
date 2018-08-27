using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public enum States4
{
    wandermap,
    seek,
    explood
}
public class boomman : MonoBehaviour {
    public NavMeshAgent agent;
    public States4 state;
    public float radius;
    public float radius2;
    enemywander wander;
    ememyseek seek;
    exploodbad boom;
    public Animator boooom;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        seek = GetComponent<ememyseek>();
        wander = GetComponent<enemywander>();
        boom = GetComponent<exploodbad>();
        agent.Warp(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemaniger.GM.pose == true)
        {
            agent.isStopped = true;
           boooom.enabled = false;
            return;
        }
        boooom.enabled = true;
        switch (state)
        {
            case States4.wandermap:
                agent.destination = transform.position + wander.wandercontol();
                agent.speed = wander.speed;
                boooom.SetBool("explood", false);
                boom.time = 1.2f;
                agent.isStopped = false;
                break;
            case States4.seek:
                agent.destination = seek.returnttargetspos();
                if (Vector3.Distance(transform.position, seek.transform.position) <= 2)
                {
                    state = States4.wandermap;
                }
                break;
            case States4.explood:
                boom.explood();
                boooom.SetBool("explood", true);
                boom.time -= Time.deltaTime;
                break;

        }
        //if(state == States4.seek)
        //{
        //    swichstate2();
        //}
        if (state == States4.wandermap)
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
                if (hit.gameObject != null)
                {
                    state = States4.explood;
                    agent.isStopped = true;
                }
            }



        }
    }
    //void swichstate2()
    //{
    //    Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius2);
    //    foreach (Collider hit in hitColliders)
    //    {
    //        if (hit.tag == "Player1" || hit.tag == "Player2")
    //        {
    //            state = States4.explood;
    //            agent.isStopped = true;
    //        }



    //    }
    //}
}
