using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMask : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D mask)
    {
        if (mask.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
        
    }
}
