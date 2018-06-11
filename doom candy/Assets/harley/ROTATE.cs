using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE : MonoBehaviour {
    //public
    [Header("Note all rotation in degrees per second")]
    public Vector3 AdditiveRotationRate = new Vector3(15, 15, 15);
    public bool UsesFixedUpdate = false;
    [Header("Sine wave rotation settings")]
    public bool SineWaveRotate = false;
    public Vector3 Amplitude = new Vector3(90, 90, 90);
    public Vector3 Frequency = new Vector3(2, 2, 2);
    //private
    private Vector3 SineWaveRotationOffset = new Vector3();

    // Use this for initialization
    private void Start()
    {
        SineWaveRotationOffset = transform.rotation.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        if (UsesFixedUpdate == false)
        {
            PreformRotate();
        }
    }
    // Fixed update is called every .02 seconds
    private void FixedUpdate()
    {
        if (UsesFixedUpdate)
        {
            PreformRotate();
        }
    }
    //called to rotate object
    private void PreformRotate()
    {
        if (SineWaveRotate)
        {
            //sine wave rotation
            //where in the waves am I?
            Vector3 sineWaveRotation = SineWaveRotationOffset + new Vector3(Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency.x) * Amplitude.x, Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency.y) * Amplitude.y, Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency.z) * Amplitude.z); ;
            //set rotation
            transform.eulerAngles = sineWaveRotation;

        }
        else
        {
            //non sine wave rotation
            float deltaTime = Time.deltaTime;
            transform.Rotate(AdditiveRotationRate.x * deltaTime, AdditiveRotationRate.y * deltaTime, AdditiveRotationRate.z * deltaTime);
        }
    }
}