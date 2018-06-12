using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class newemap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.tag == "Player1")
        {
            SceneManager.LoadScene("");
        }
    }
}
