using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenuButton : MonoBehaviour
{
    public GameObject creditscreen;
    public GameObject HowToPlayScreen;
    public Sprite Speakeron;
    public Sprite Speakeroff;
    public Button speaker;
    public AudioSource musica;
    public bool nyala=true;
    
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    //credits
       public void CreditsButton()
    {
        creditscreen.SetActive(true);
    }
    public void ExitCredits()
    {
        creditscreen.SetActive(false);
    }
    //howtoplay
         public void HowToPlayButton()
    {
        HowToPlayScreen.SetActive(true);
    }
        public void ExitHowToPlay()
    {
        HowToPlayScreen.SetActive(false);
    }
    
    public void TurnAudio()
    {
        if(nyala == true)
        {
            AudioListener.volume = 0;
            nyala = false;
        }
        else
        {
            AudioListener.volume = 1;
            nyala = true;
        }
    }

    public void TurnSpeaker()
    {
        
        if(nyala == true)
        {
            speaker.image.sprite = Speakeron;
        }
        else
        {
            speaker.image.sprite = Speakeroff; 
        }
    }
}
