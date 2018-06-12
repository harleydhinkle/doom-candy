using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCollisionInteractionShop : MonoBehaviour
{


    public GameObject thing;
    public GameObject thing2;
    public bool canInteract;
    public void OnTriggerStay(Collider other)
    {
        controller con = other.GetComponent<controller>();
        if (con != null)
        {
            //Set the controller to the interact state
            canInteract = true;
            thing.SetActive(true);
            if (con.shop)
            {
                
                if (other.tag == "Player1")
                {
                    thing2.SetActive(true);
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        controller con = other.GetComponent<controller>();
        if (con != null)
        {
            canInteract = false;
            thing.SetActive(false);
            thing2.SetActive(false);
            con.shop = false;
        }

    }
}
