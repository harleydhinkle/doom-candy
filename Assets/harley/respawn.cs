using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class respawn : MonoBehaviour {
    public Transform[] respawnpoints;
    public GameObject player1;
    public GameObject player2;

    // Use this for initialization
    void Start() {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public Vector3 pickspawn(GameObject player)
    {
        Transform cho = null;
        float max = Mathf.NegativeInfinity;
        for (int i = 0; i < respawnpoints.Length; i++)
        {
            float dis = Vector3.Distance(respawnpoints[i].position, player.transform.position);
            //Loop Through all the enemies and make sure the spawn point is atleast Xamount away from an enemy
            if (max < dis)
            {
                cho = respawnpoints[i];
                max = dis;

            }
           
            
        }
        return cho.position;
    }

   

}
