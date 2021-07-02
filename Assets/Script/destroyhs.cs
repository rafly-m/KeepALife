using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyhs : MonoBehaviour
{
    public GameObject handsanitizer;
    void OnTriggerEnter2D(Collider2D hs)
    {
        if (hs.gameObject.tag != "Player")
        {
            gameObject.SetActive(false);
        }
      
    }

}
