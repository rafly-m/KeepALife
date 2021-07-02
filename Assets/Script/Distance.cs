using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Text DisText;
    public float DisPassed1;
    public float DisPassed2;
    public float DisPlus;
    public Text maxscore;
    // Start is called before the first frame update
    void Start()
    {
        DisPassed1=0f;
        DisPassed2=0f;

    }

    // Update is called once per frame
    void Update()
    {
        DisText.text = (int)DisPassed1 + " M";
        maxscore.text = (int)DisPassed2 + " M";
        increasedistance();
    }
    public void increasedistance()
    {
        DisPassed1 +=DisPlus * Time.deltaTime;
        DisPassed2 +=DisPlus * Time.deltaTime;
    }
}
