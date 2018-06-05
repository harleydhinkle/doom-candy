using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public Rigidbody bullet;
    public Stack<GameObject> enemies;
    public Transform target;
    public float speed = 1000;
    public float fireRate;
    public float spawnRandomizer;
    float timer;
    public float range;
    public List<GameObject> targets;

    void Start()
    {
        enemies = new Stack<GameObject>();
        getTargets();
        timer = fireRate;
        target = null;
    }

    void Update()
    {
        targets.Clear();
        getTargets();
        timer += Time.deltaTime;

        enemies.Clear();

        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.position) <= range)
            {
                if (timer >= fireRate)
                {
                    Rigidbody tim = Instantiate(bullet, transform.position + new Vector3(Random.Range(-spawnRandomizer, spawnRandomizer), 0, Random.Range(-spawnRandomizer, spawnRandomizer)), transform.rotation) as Rigidbody  ;

                    Vector3 dir = (target.position - transform.position).normalized;
                    dir.y = 0;
                    tim.GetComponent<Bullet>().dir = dir;
                    tim.AddForce((dir * speed) * Time.deltaTime, ForceMode.Impulse);
                    timer = 0;
                }

            }
        }
        else
        {
            getNewTarget();
            if (target == null)
            {
                Debug.Log("Killed everything shoot");
            }
        }
    }

    void getTargets()
    {
        GameObject[] Enemy = GameObject.FindGameObjectsWithTag("Player1");

        for (int i = 0; i < Enemy.Length; i++)
        {
            targets.Add(Enemy[i]);
        }
    }

    void getNewTarget()
    {


        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Player1"))
        {
            enemies.Push(item);
        }

        foreach (GameObject item in enemies)
        {
            if (Vector3.Distance(item.transform.position, transform.position) <= range)
            {
                target = item.transform;
            }
        }
    }
}
