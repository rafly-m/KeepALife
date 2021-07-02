using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hsspawn : MonoBehaviour
{
   public GameObject hs;
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
        if(currdis >= 600f)
        {
            Debug.Log ("masker");
            hs.gameObject.SetActive(true);
            currdis = 0f;
        }
    }
}
