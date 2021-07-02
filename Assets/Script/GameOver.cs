using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text distance;
    public float urscore = 2f;

    public void finaldis ()
    {
        
        distance.text = urscore + " M";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void backtomenubutton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
