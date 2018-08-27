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
    public float leftrun;
    public float rightrun;
    public bool reload;
    public bool reloadgun;
    public int swich;
    public int gun = 1;
    public int bash = 0;
    public GameObject gun3;
    public bool gunoff;
    public bool firebash;
    public GameObject damige;
    public GameObject damige2;
    public bool door;
    public Animator player3;
    public Animator player4;
    public bool shop;
    public AudioSource playme;
    public AudioClip gunsound;
    public GameObject buyui;
    public GameObject buyui2;
    public player_movment yey;
    public GameObject stop;
    IEnumerator startviprat()
    {
        GamePad.SetVibration(playerIndex, leftrun, rightrun);
        yield return new WaitForSeconds(.4f);
        GamePad.SetVibration(playerIndex, 0, 0);
    }
    // Use this for initialization
    //void Start () {
    //   //if(playernum == 1) { playerIndex = PlayerIndex.One; }
    //   // if (playernum == 2) { playerIndex = PlayerIndex.Two; }

    //}
	
	// Update is called once per frame
	void Update ()
    {
        if(gamemaniger.GM.pose == true)
        {
            return;
        }
        prevState = state;
        state = GamePad.GetState(playerIndex);
        if (gamemaniger.GM.keybordcontrols == true)
        {
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
            if (gunoff == false)
            {
                if (Input.GetMouseButtonDown(0) && reload == false)
                {
                    //StartCoroutine(startviprat());
                    player3.SetBool("fire", true);
                    playme.clip = gunsound;
                    playme.Play();
                    firegun = true;
                }
                else
                {
                    firegun = false;
                    player3.SetBool("fire", false);
                }
            }
            if (gunoff == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    firebash = true;
                    player4.SetBool("hit", true);
                    yey.do_do.playfaceeffect(FaceStates.shoot);
                    damige.SetActive(true);
                }
                else
                {
                    firebash = false;
                    player4.SetBool("hit", false);
                    damige.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                reloadgun = true;

            }
            else
            {
                reloadgun = false;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (swich == 0)
                {
                    swich = 1;
                    gunoff = true;
                    gun3.SetActive(false);
                    damige2.SetActive(true);

                }
                else if (swich == 1)
                {
                    swich = 0;
                    gunoff = false;
                    gun3.SetActive(true);
                    damige2.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gamemaniger.GM.pose = true;
                stop.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                door = true;
                shop = true;
                buyui.SetActive(false);
                buyui2.SetActive(false);
            }
            else
            {
                shop = false;
                door = false;
            }
            if (vertical == 1)
            {
                player3.SetBool("walk", true);
                if (gunoff == true)
                {
                    player4.SetBool("run", true);
                }
            }
            if(vertical== -1)
            {
                player3.SetBool("walk", true);
                if (gunoff == true)
                {
                    player4.SetBool("run", true);
                }
            }
            if(horizontal == 1)
            {
                player3.SetBool("walk", true);
                if (gunoff == true)
                {
                    player4.SetBool("run", true);
                }
            }
            if (horizontal == -1)
            {
                player3.SetBool("walk", true);
                if (gunoff == true)
                {
                    player4.SetBool("run", true);
                }
            }
            if (horizontal == 0 && vertical == 0)
            {
                player3.SetBool("walk", false);
                if (gunoff == true)
                {
                    player4.SetBool("run", false);
                }
            }

        }
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    hit = true;
        //}
        //else
        //{
        //    hit = false;
        //}
        if (gamemaniger.GM.keybordcontrols == false)
        {
            if (contrler1 == true)
            {
                horizontal = state.ThumbSticks.Left.X;
                vertical = state.ThumbSticks.Left.Y;
                if (vertical >= 0.2f)
                {
                    player3.SetBool("walk", true);
                    if (gunoff == true)
                    {
                        player4.SetBool("run", true);
                    }
                }
                if (vertical <= -0.2f)
                {
                    player3.SetBool("walk", true);
                    if (gunoff == true)
                    {
                        player4.SetBool("run", true);
                    }
                }
                if (horizontal >= 0.2f)
                {
                    player3.SetBool("walk", true);
                    if (gunoff == true)
                    {
                        player4.SetBool("run", true);
                    }
                }
                if (horizontal <= -0.2f)
                {
                    player3.SetBool("walk", true);
                    if (gunoff == true)
                    {
                        player4.SetBool("run", true);
                    }
                }
                if (horizontal == 0 && vertical == 0)
                {
                    player3.SetBool("walk", false);
                    if (gunoff == true)
                    {
                        player4.SetBool("run", false);
                    }
                }
                if (gunoff == false)
                {
                    if (prevState.Triggers.Right <= 0.2f && state.Triggers.Right >= .5f && reload == false)
                    {
                        StartCoroutine(startviprat());
                        player3.SetBool("fire", true);
                        playme.clip = gunsound;
                        playme.Play();
                        firegun = true;


                    }
                    else
                    {
                        firegun = false;
                        player3.SetBool("fire", false);
                    }

                }
                if (gunoff == true)
                {
                    if (/*prevState.Triggers.Right <= 0.0 && */state.Triggers.Right >= 0.5)
                    {
                        firebash = true;
                        player4.SetBool("hit", true);
                        yey.do_do.playfaceeffect(FaceStates.shoot);
                        damige.SetActive(true);

                    }
                    if (state.Triggers.Right == 0.0)
                    {
                        firebash = false;
                        player4.SetBool("hit", false);
                        damige.SetActive(false);
                    }
                }
                if (prevState.Buttons.Start == ButtonState.Released && state.Buttons.Start == ButtonState.Pressed)
                {
                    gamemaniger.GM.pose = true;
                    stop.SetActive(true);


                }
                if (prevState.Buttons.X == ButtonState.Released && state.Buttons.X == ButtonState.Pressed )
                {
                    reloadgun = true;
                }
                else
                {
                    reloadgun = false;
                }
                if (prevState.Buttons.A == ButtonState.Released && state.Buttons.A == ButtonState.Pressed)
                {
                    door = true;
                    shop = true;
                    buyui.SetActive(false);
                    buyui2.SetActive(false);
                }
                if (prevState.Buttons.A == ButtonState.Pressed && state.Buttons.A == ButtonState.Released)
                {
                    shop = false;
                    door = false;
                }
                horizontalcamra = state.ThumbSticks.Right.X;
                verticalcamra = state.ThumbSticks.Right.Y;
                if (prevState.Buttons.Y == ButtonState.Released && state.Buttons.Y == ButtonState.Pressed )
                {
                    if (swich == 0)
                    {
                        swich = 1;
                        gunoff = true;
                        gun3.SetActive(false);
                        damige2.SetActive(true);

                    }
                    else if (swich == 1)
                    {
                        swich = 0;
                        gunoff = false;
                        gun3.SetActive(true);
                        damige2.SetActive(false);
                    }
                }
            }
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
            if (prevState.Buttons.X == ButtonState.Released && state.Buttons.X == ButtonState.Pressed)
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
    }
  
}
