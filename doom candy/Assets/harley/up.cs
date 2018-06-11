using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour {
    //public
    public Vector3 Amplitude = new Vector3(0, 0.5f, 0);
    public Vector3 Frequency = new Vector3(1, 1, 1);
    public bool UsesFixedUpdate = false;
    //private
    private Vector3 SineWaveHoverOffset = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start()
    {
        SineWaveHoverOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (UsesFixedUpdate == false)
        {
            PreformHover();
        }
    }
    // FixedUpdate is called every 0.02 seconds
    private void FixedUpdate()
    {
        if (UsesFixedUpdate)
        {
            PreformHover();
        }
    }
    private void PreformHover()
    {
        Vector3 waveValues = new Vector3();
        waveValues.x += Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency.x) * Amplitude.x;
        waveValues.y += Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency.y) * Amplitude.y;
        waveValues.z += Mathf.Sin(Time.fixedTime * Mathf.PI * Frequency.z) * Amplitude.z;
        Vector3 tempPos = SineWaveHoverOffset + waveValues;
        transform.position = tempPos;
    }
}
