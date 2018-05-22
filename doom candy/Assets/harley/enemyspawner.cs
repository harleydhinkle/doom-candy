using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public List<GameObject> listOfEnemies;
    public GameObject Enemey;
    public float range;
    public float time;
    private float timer;
    public int currentanmontofenemys;
    public int max;
    // Use this for initialization
    void Start()
    {
        listOfEnemies = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0 && currentanmontofenemys < max)
        {
            SpawnFunction();
        }
    }
    public void SpawnFunction()
    {
        GameObject spawnedEnemey = Instantiate(Enemey);
        float x = Random.Range(-range, range);
        float z = Random.Range(-range, range);
        spawnedEnemey.transform.position = transform.position + new Vector3(x, 0, z);
        listOfEnemies.Add(spawnedEnemey);
        spawnedEnemey.GetComponent<NewBehaviourScript>().enemy3 = this;
        currentanmontofenemys += 1;
        timer = time;
        //Spawn The enemy just like the pick up

    }
}
