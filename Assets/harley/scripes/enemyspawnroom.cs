using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawnroom : MonoBehaviour {
    public GameObject[] enemys;
    public GameObject[] rooms;
    public float range;
    public float time;
    private float timer;
    public int currentanmontofenemys;
    public int number_spawn;
    public int max;
    public player_movment player1;
    public GunUI play;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gamemaniger.GM.pose == true)
        {
            return;
        }
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
        if (currentanmontofenemys < max - number_spawn)
        {
            for (int i = 0; i < number_spawn; i++)
            {

                GameObject spawnenemys = Instantiate(enemys[Random.Range(0, enemys.Length)]);
                GameObject spawnroom = rooms[Random.Range(0, rooms.Length)];
                spawnenemys.GetComponent<NewBehaviourScript>().player1 = player1;
                spawnenemys.transform.position = spawnroom.transform.position;
                spawnenemys.GetComponent<NewBehaviourScript>().enemy3 = this;
                spawnenemys.GetComponent<NewBehaviourScript>().play = play;
                currentanmontofenemys += 1;

            }
        }
        timer = time;
    }
}
