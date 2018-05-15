using System.Collections;
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
                if (prevState.Buttons.RightShoulder == ButtonState.Released && state.Buttons.RightShoulder == ButtonState.Pressed)
                {
                    firegun = true;

                }
            else
            {
                firegun = false;
            }
            horizontalcamra = state.ThumbSticks.Right.X;
            verticalcamra = state.ThumbSticks.Right.Y;
             }
        if(contrler2 == true)
        {
            horizontal = state.ThumbSticks.Left.X;
            vertical = state.ThumbSticks.Left.Y;
            if (prevState.Buttons.RightShoulder == ButtonState.Released && state.Buttons.RightShoulder == ButtonState.Pressed)
            {
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
