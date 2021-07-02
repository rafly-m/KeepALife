using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movespeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movespeed = new Vector2(0,-speed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =(Vector2) transform.position + movespeed;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
