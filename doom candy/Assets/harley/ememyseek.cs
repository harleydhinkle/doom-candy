using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ememyseek : MonoBehaviour {
    Vector3 desired;
    public float speed;
    public Transform target;
    // Use this for initialization
    public Vector3 returnttargetspos()
    {
        return target.position;
    }
}
