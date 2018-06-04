using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemywander : MonoBehaviour {

    public float dis;
    public float radius;
    public float speed;
    public float jitter;
    public Vector3 target;
    public Vector3 wandercontol()
    {
        target = Vector3.zero;
        target = Random.insideUnitCircle.normalized * radius;
        target = (Vector2)target + Random.insideUnitCircle.normalized * jitter;

        target.z = target.y;
        //target += transform.position;
        target += transform.forward * dis;
        target.y = 0;
        return target;

    }
}
