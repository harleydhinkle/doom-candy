using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploodbad : MonoBehaviour {
    public float range;
    public float time;
    public GameObject pow;
    public void explood()
    {
        if(time <= 0)
        {
            var spawnBaby = Instantiate(pow);
            spawnBaby.transform.position = transform.position;
            Destroy(gameObject);
        }
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, range);
        foreach (Collider hit in hitColliders)
        {
            if (hit.tag == "Player1" || hit.tag == "Player2")
            {
                //if (time <= 0)
                //{
                //    var spawnBaby = Instantiate(pow);
                //    spawnBaby.transform.position = transform.position;
                //    Destroy(gameObject);


                //}
            }



        }
    }
}
