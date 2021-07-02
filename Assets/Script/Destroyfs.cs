using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyfs : MonoBehaviour
{

      private void OnTriggerEnter2D(Collider2D fs)
    {
        if (fs.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
        
    }
}
