using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disdeactive : MonoBehaviour
{
    public Animator hsoff;
    public AudioSource hsmute;
     void OnCollisionEnter2D(Collision2D dishs)
    {
        if (dishs.gameObject.tag == "Obstacle")
        {
            hsmute.Stop();
            hsoff.SetBool("Semprot", false);
            gameObject.SetActive(false);
        }
    }

}
