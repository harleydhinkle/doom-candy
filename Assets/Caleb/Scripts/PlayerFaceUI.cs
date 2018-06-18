using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum FaceStates
{
    damaged,
    normal,
    shoot,
    get
}

public class PlayerFaceUI : MonoBehaviour {
    //create an array
    public Sprite[] faceUI;
    //for the image
    public Image face;


    //called in order to change face
    void changeFace(FaceStates state)
    {
        //if statement to prevent errors
        if((int)state >= faceUI.Length) { return; }
        face.sprite = faceUI[(int)state];

    }
    //allows for public use of changing faces
    public void playfaceeffect(FaceStates face)
    {
        StartCoroutine(faces(face));
    }
    //changes faces for action and returns to normal
    IEnumerator faces(FaceStates face)
    {
        changeFace(face);
        yield return new WaitForSeconds(.4f);
        changeFace(FaceStates.normal);
    }
}
