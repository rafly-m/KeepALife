using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    private float width;
    public float scrollspeed = 2f;
    public GameObject obs1;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        
        width = collider.size.y;
        collider.enabled=false;

        rb.velocity = new Vector2(0,-scrollspeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -width)
        { 
            Vector2 resetPosition = new Vector2(0, width * 2f);
            transform.position=(Vector2)transform.position + resetPosition;
            obs1.gameObject.SetActive(true);
            if (transform.position.y > 9f)
            {
                ResetObstacle();
            }
            
        }
        
     

    }

    //Obstacle
    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(Random.Range(-4,4),13,0);
        transform.GetChild(1).localPosition = new Vector3(Random.Range(-4,4),13,0);
        transform.GetChild(2).localPosition = new Vector3(Random.Range(-4,4),13,0);
        transform.GetChild(3).localPosition = new Vector3(Random.Range(-4,4),13,0);
        transform.GetChild(4).localPosition = new Vector3(Random.Range(-4,4),13,0);
        obs1.gameObject.SetActive(false);
    }
}
