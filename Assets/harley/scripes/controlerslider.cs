using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;
using UnityEngine.UI;
public class controlerslider : MonoBehaviour {
    public PlayerIndex pIdx;
    GamePadState state;
    GamePadState PrevState;
    public Button button;
    public Slider slider;
    public AudioSource sound;
    public float speed;
    public Selectable selectable;
    // Use this for initialization
    //void Start()
    //{
    //    selectable = button;

    //}

    int downCount = 0;
    public bool getButtonDown()
    {

        if (PrevState.Buttons.A == ButtonState.Released && state.Buttons.A == ButtonState.Pressed)
        {
            downCount++;
            if (downCount > 1)
            {
                return false;
            }

            return true;
        }
        downCount = 0;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        PrevState = state;
        state = GamePad.GetState(pIdx);
        Vector3 Dir = Vector3.zero;

        if (PrevState.ThumbSticks.Left.Y == 0 && state.ThumbSticks.Left.Y != 0)
        {
            Dir.y = state.ThumbSticks.Left.Y;
        }

        if (PrevState.ThumbSticks.Left.X == 0 && state.ThumbSticks.Left.X != 0)
        {
            Dir.x = state.ThumbSticks.Left.X;
        }


        Selectable trySelect = selectable.FindSelectable(Dir);

        if (trySelect != null)
        {
            if (sound != null)
            {
                sound.Play();
            }

            selectable = trySelect;
            if (selectable.GetComponent<Button>())
            {
                button = selectable.GetComponent<Button>();
                slider = null;
            }
            if (selectable.GetComponent<Slider>())
            {
                slider = selectable.GetComponent<Slider>();
                button = null;
            }

        }

        if (getButtonDown())
        {
            if (button != null)
            {
                button.onClick.Invoke();
            }
            

        }
        if (button != null)
        {
            button.Select();
        }
        if(state.Buttons.A == ButtonState.Pressed)
        {
            if (slider != null)
            {
                slider.value += state.ThumbSticks.Left.X / speed;
            }
        }
        if(slider != null)
        {
            slider.Select();
        }

        
    }
}
