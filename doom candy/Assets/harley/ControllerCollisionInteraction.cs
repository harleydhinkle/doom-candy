using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCollisionInteraction : MonoBehaviour {


    public GameObject thing;
    public bool canInteract;
    public PurchaseScript buy4;
    public void OnTriggerStay(Collider other)
    {
        controller con = other.GetComponent<controller>();
        if(con != null)
        {
            //Set the controller to the interact state
            canInteract = true;
            thing.SetActive(true);
            if(con.door)
            {
                if (buy4.price <= buy4.buy.points)
                {
                    buy4.canbuy = true;
                }
                else
                {
                    buy4.canbuy = false;
                }
                if (buy4.canbuy == true)
                {
                    buy4.purchase();
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        controller con = other.GetComponent<controller>();
        if(con != null)
        {
            canInteract = false;
            thing.SetActive(false);
        }
    }



}
