using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    public float horizontal;
    public float vertical;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W)&& !Input.GetKey(KeyCode.S))
        {
            vertical = 1;
        }
        if (Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.W))
        {
            vertical = -1;
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            horizontal = -1;
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKeyDown(KeyCode.A))
        {
            horizontal = 1;
        }
        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            horizontal = 0;
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            vertical = 0;
        }
    }
}
