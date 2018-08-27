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
        health.text = "health: " + move.currenthealth.ToString()+"%";
        armor.text = "lives: " + move.lives.ToString();
        //armor.text = ;
        //weapon.text = ;
        //ammo.text = move.currentclip.ToString() + "/" + move.currentaimo.ToString();
        score.text = "score: " + move.points.ToString();
        //time.text = ;

    }
	
	// Update is called once per frame
	void Update ()
    {

    }
    //for updating health in hud
    public void health2()
    {
        health.text = "health: " + move.currenthealth.ToString()+"%";
    }
    //for updating ammo stock in hud
    public void ammo2()
    {
        ammo.text = "ammo: " + move.currentclip.ToString() + "/" + move.currentaimo.ToString();
    }
    //for updating player score in hud
    public void score2()
    {
        score.text = "score: " + move.points.ToString();
    }
    public void lives()
    {
        armor.text = "lives: " + move.lives.ToString();
    }

}
