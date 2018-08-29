using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booooooom : MonoBehaviour {
    public float timer;
    // Use this for initialization
    void Start () {
        timer = 2;
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
