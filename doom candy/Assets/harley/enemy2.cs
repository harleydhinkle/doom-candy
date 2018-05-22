using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public enum States
{
    wandermap,
    seek
}
public class enemy2 : MonoBehaviour
{
    NavMeshAgent agent;
    public States state;
    public float radius;
    enemywander wander;
    ememyseek seek;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        seek = GetComponent<ememyseek>();
        wander = GetComponent<enemywander>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case States.wandermap:
                agent.destination = wander.wandercontol();
                break;
            case States.seek:
                agent.destination = seek.returnttargetspos();
                if (Vector3.Distance(transform.position, seek.transform.position) <= 50)
                {
                    state = States.wandermap;
                }
                break;
        }
        if (state == States.wandermap)
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
                state = States.seek;
                seek.target = hit.transform;
            }



        }
    }
}
