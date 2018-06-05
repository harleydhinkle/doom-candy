using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int damage;

    public float lifetime;
    public Vector3 dir;
    float timer;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;


        Debug.DrawLine(transform.position, transform.position + (dir * 10));
    }


    void OnTriggerEnter(Collider other)
    {
        var tamp = other.GetComponent<IDamageable>();
        if (other.tag == "Player1")
        {
            tamp.takeDamage(damage, 0, other.GetComponent<player_movment>());
            Destroy(gameObject);
        }

    }
}
