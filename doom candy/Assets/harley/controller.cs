﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class controller : MonoBehaviour {
    public float horizontal;
    public float vertical;
    public float horizontalcamra;
    public float verticalcamra;
    public int playernum;
    public bool hit;
    public bool firegun;
    public PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;
    public bool contrler1;
    public bool contrler2;
    public float leftrun;
    public float rightrun;
    public bool reload;
    public bool reloadgun;
    IEnumerator startviprat()
    {
        GamePad.SetVibration(playerIndex, state.Triggers.Right, state.Triggers.Right);
        yield return new WaitForSeconds(.2f);
        GamePad.SetVibration(playerIndex, 0, 0);
    }
    // Use this for initialization
    void Start () {
       //if(playernum == 1) { playerIndex = PlayerIndex.One; }
       // if (playernum == 2) { playerIndex = PlayerIndex.Two; }

    }
	
	// Update is called once per frame
	void Update ()
    {
        prevState = state;
        state = GamePad.GetState(playerIndex);
       
            if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                vertical = 1;
            }
            if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
            {
                vertical = -1;
            }
            if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                horizontal = -1;
            }
            if (Input.GetKey(KeyCode.D) && !Input.GetKeyDown(KeyCode.A))
            {
                horizontal = 1;
            }
            if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            {
                horizontal = 0;
            }
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                vertical = 0;
            }
            //if (Input.GetKeyDown(KeyCode.F))
            //{
            //    hit = true;
            //}
            //else
            //{
            //    hit = false;
            //}
            if (Input.GetKeyDown(KeyCode.C))
            {
                firegun = true;
            }
            else
            {
                firegun = false;
            }
            if (contrler1 == true)
            {
                horizontal = state.ThumbSticks.Left.X;
                vertical = state.ThumbSticks.Left.Y;
            if (prevState.Triggers.Right <= 0.2f && state.Triggers.Right >= .5f&&reload == false)
            {
                StartCoroutine(startviprat());
                firegun = true;


            }
            else
            {
                firegun = false;
            }
            if(prevState.Buttons.X == ButtonState.Released && state.Buttons.X == ButtonState.Pressed)
            {
                reloadgun = true;
            }
            else
            {
                reloadgun = false;
            }
            horizontalcamra = state.ThumbSticks.Right.X;
            verticalcamra = state.ThumbSticks.Right.Y;
             }
        if(contrler2 == true)
        {
            horizontal = state.ThumbSticks.Left.X;
            vertical = state.ThumbSticks.Left.Y;
            if (prevState.Triggers.Right == 0 && state.Triggers.Right == 1)
            {
                GamePad.SetVibration(playerIndex,state.Triggers.Right, state.Triggers.Right);
                firegun = true;
                

            }
            else
            {
                firegun = false;
            }
            horizontalcamra = state.ThumbSticks.Right.X;
            verticalcamra = state.ThumbSticks.Right.Y;
        }
    }
}
