using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpcontrol : MonoBehaviour
{
    int i;
    public GameObject washand;
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
        if(currdis >= 500 && currdis <=501)
        {
            washand.gameObject.SetActive(true);
            currdis = 0;
            Invoke("washoff",3f);
        }
    }

    public void washoff()
    {
        washand.gameObject.SetActive(false);
    }
}
