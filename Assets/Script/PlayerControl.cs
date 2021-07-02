using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movevelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"),0);
        movevelocity = moveInput * speed;
        
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movevelocity * Time.fixedDeltaTime);
    }
}