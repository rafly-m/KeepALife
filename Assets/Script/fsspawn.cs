using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fsspawn : MonoBehaviour
{
    public GameObject fs;
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
        if(currdis >= 300f)
        {
            Debug.Log ("masker");
            fs.gameObject.SetActive(true);
            currdis = 0f;
        }
    }
}
