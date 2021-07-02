using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObstacle : MonoBehaviour
{
    public AudioSource damage;
    int count = 0; 
    int maxcount = 5;  
    
    private void OnCollisionEnter2D(Collision2D obs)
    {
        if (obs.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            count++;
            damage.Play();
        }
        if (obs.gameObject.tag == "hsdistance")
        {
            gameObject.SetActive(false);
        }

    }
}
