using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    public GameObject washplace;
    public Text counter;
    public int urcheck;
    public int pluswan;
    // Start is called before the first frame update
    void Start()
    {
        urcheck = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = urcheck.ToString();
        plus();

    }

    void plus()
    {
        urcheck = pluswan;
    }

    public void OnTriggerEnter2D(Collider2D wash)
    {
        if(wash.gameObject.tag == "Player")
        {
            pluswan++;
        }
    }
}
