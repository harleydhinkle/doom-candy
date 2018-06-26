using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemaniger : MonoBehaviour {
    public static gamemaniger GM;
    public bool pose = false;
    void Awake()
    {
        if (GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }
        else if (GM != this)
        {
            Destroy(gameObject);
        }
    }
}
