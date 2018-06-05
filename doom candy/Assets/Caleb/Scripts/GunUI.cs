using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GunUI : MonoBehaviour {

    public Text health;
    public Text armor;
    public Text weapon;
    public Text ammo;
    public Text score;
    public Text time;
    public player_movment move;

	// Use this for initialization
	void Start ()
    {
        move = FindObjectOfType<player_movment>();
        health.text = move.currenthealth.ToString()+"%";
        //armor.text = ;
        //weapon.text = ;
        //ammo.text = move.currentclip.ToString() + "/" + move.currentaimo.ToString();
        score.text = move.points.ToString();
        //time.text = ;
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    //for updating health in hud
    public void health2()
    {
        health.text = move.currenthealth.ToString()+"%";
    }
    //for updating ammo stock in hud
    public void ammo2()
    {
        ammo.text = move.currentclip.ToString() + "/" + move.currentaimo.ToString();
    }
    //for updating player score in hud
    public void score2()
    {
        score.text = move.points.ToString();
    }

}
