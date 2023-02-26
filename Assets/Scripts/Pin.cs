using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float Pinspeed = 1f;
    public Rigidbody2D rb;
    public Slider PinSpeedSlider;

    public void Start()
    {
        Pinspeed = PlayerPrefs.GetFloat("newPinSpeed");
    }

    public void FixedUpdate ()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * Pinspeed * Time.fixedDeltaTime);
             PlayerPrefs.SetFloat("newPinSpeed", Pinspeed);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        } else if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void AdjustSpeed(float newPinSpeed)
    {
        Pinspeed = newPinSpeed;
    }
}
