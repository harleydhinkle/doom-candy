using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject spawn;
    public float range;
    public float spawnInterval;
    public float spawntimer;
    // Use this for initialization
    void Start()
    {

    }

    void spawnEnemy()
    {
        GameObject spawnedEnemy = Instantiate(spawn);
        float randX = Random.Range(-range, range);
        float randZ = Random.Range(-range, range);
        spawnedEnemy.transform.position = transform.position + new Vector3(randX, 1, randZ);
        spawnedEnemy.GetComponent<enemy>().scoreAdded = Random.Range(-5, 30);
    }

    // Update is called once per frame
    void Update()
    {
        spawntimer -= Time.deltaTime;
        if (spawntimer <= 0)
        {
            spawntimer = spawnInterval;
            spawnEnemy();
        }
    }
}
