using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public float redTime;
    public float orangeTime;
    public float greenTime;
    public Light redLight;
    public Light orangeLight;
    public Light greenLight;

    private float timer = 0f;

    void Start()
    {
        orangeLight.enabled = false;
        greenLight.enabled = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (redLight.enabled && timer > redTime)
        {
            timer = 0f;
            redLight.enabled = false;
            greenLight.enabled = true;
        }
        else if (greenLight.enabled && timer > greenTime)
        {
            timer = 0f;
            greenLight.enabled = false;
            orangeLight.enabled = true;
        }
        else if (orangeLight.enabled && timer > orangeTime)
        {
            timer = 0f;
            orangeLight.enabled = false;
            redLight.enabled = true;
        }
    }
}
