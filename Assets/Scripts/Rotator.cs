using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public float speed;
    public Slider rotationSlider;

    public void Start()
    {
        speed = PlayerPrefs.GetFloat("newSpeed");
    }

    void Update () 
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
        PlayerPrefs.SetFloat("newSpeed", speed);
    }

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
