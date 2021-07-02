using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsspawn : MonoBehaviour
{
    public GameObject obs1,obs2;
    public Rigidbody2D obs;

    public float currdis;
    public float displus = 0f;
    void Start()
    {
        currdis = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        currdis += displus * Time.deltaTime;  
        if(currdis >= 50)
        {
            Debug.Log ("aaaaaaaa");
            obs1.gameObject.SetActive(true);
            obs2.gameObject.SetActive(true);
            currdis = 0f;
        }
    }
}
