﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Player1")
        {
            gamemaniger.GM.pose = true;
            SceneManager.LoadScene("WinScreen");
        }
    }
}
