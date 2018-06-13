using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public enum States2
{
    wandermap,
    seek,
    isInRange
}
public class enemyshooutinhswicth : MonoBehaviour {

    NavMeshAgent agent;
    public States2 state;
    public float radius;
    enemywander wander;
    ememyseek seek;
    public Rigidbody fire;
    public float throwpower;
    public float radius2;
    public Transform target;
    public float time;
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        seek = GetComponent<ememyseek>();
        wander = GetComponent<enemywander>();
        time = 10;
    }

    // Update is called once per frame
    void Update () {
        switch (state)
        {
            case States2.wandermap:
                agent.destination = wander.wandercontol();
                break;
            case States2.seek:
                agent.destination = seek.returnttargetspos();
                if (Vector3.Distance(transform.position, seek.transform.position) <= 50)
                {
                    state = States2.wandermap;
                }
                break;
            case States2.isInRange:
                transform.LookAt(target);
                kill();
                time = 10;
                if(time >= 0)
                {
                    time -= Time.deltaTime;
                    state = States2.wandermap;
                }
                break;
              
        }
        if (state == States2.wandermap)
        {
            swichstate();
        }

    }
    void kill()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius2);
        foreach (Collider hit in hitColliders)
        {
            if (hit.tag == "Player1")
            {
                Rigidbody fire2 = Instantiate(fire, transform.position, transform.rotation) as Rigidbody;
                fire2.velocity = transform.position * throwpower;
                
            }



        }
    }
    void OnCollisionEnter(Collision hit)
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (hit.gameObject.tag == "Player1")
        {
            state = States2.seek;
            if (distance >= agent.stoppingDistance && distance <= agent.stoppingDistance + 5)
            {
                state = States2.isInRange;
            }
        }
    }
    void swichstate()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in hitColliders)
        {
            if (hit.tag == "Player1")
            {
                state = States2.seek;
                seek.target = hit.transform;
            }



        }
    }

}
