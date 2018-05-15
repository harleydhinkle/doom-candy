using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAudio : MonoBehaviour
{

    public AudioSource[] sound;
    public static GameAudio instance = null;
    AudioSource currentSong;

    public int currentIndex;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else { Destroy(gameObject); }
        currentSong = sound[currentIndex];
        currentSong.Play();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        //if the current song is not playing
        //then
        //Find our next index and make sure not go over
        //set our current song equal to the index that we found
        //
        //tell our currentSong to play
        //
        if (!currentSong.isPlaying)
        {
            currentIndex++;
            if (currentIndex > 1)
            {
                currentIndex = 0;
                currentSong = sound[currentIndex];
                currentSong.Play();
            }
            currentSong = sound[currentIndex];
            currentSong.Play();
        }



        //To wrap the index
        //



    }
}