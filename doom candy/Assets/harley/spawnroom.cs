using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnroom : MonoBehaviour {
    public GameObject [] rooms;
    public GameObject [] pickup;
    public float range;
    public float time;
    private float timer;
    public int max;
    public int currentpickups;
    // Use this for initialization
    public void spawn()
    {
        
        GameObject spawnpickup = Instantiate(pickup[Random.Range(0, pickup.Length)]);
        //float x = Random.Range(-range, range);
        //float z = Random.Range(-range, range);
        GameObject spawnroom = rooms[Random.Range(0, rooms.Length)];
     
        spawnpickup.transform.position = spawnroom.transform.position;
        spawnpickup.GetComponent<pickup>().sp = this;

    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0 && currentpickups < max)
        {
            spawn();
            timer = time;
            currentpickups += 1;
        }
    }

    
}
