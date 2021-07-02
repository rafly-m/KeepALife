using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskspawn : MonoBehaviour
{
    public GameObject mask;
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
        if(currdis >= 250f)
        {
            Debug.Log ("masker");
            mask.gameObject.SetActive(true);
            currdis = 0f;
        }
    }
}
