using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefs : MonoBehaviour
{
    public float speed;
    private Vector2 movespeed;
    // Start is called before the first frame update
    void Start()
    {
        movespeed = new Vector2(0,-speed);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =(Vector2) transform.position + movespeed;
    }
}
