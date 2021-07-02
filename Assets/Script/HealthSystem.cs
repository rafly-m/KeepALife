using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, heart4, heart5;
    public AudioSource bgm,sfxwash,sfxgameover,hssfx;
    public int healthdis;
    public GameObject GameOverScreen, washplace, hsdistance;
    public static int health;
    public float timemask;
    public float timefaces;
    public Slider fsslider;
    public Slider maskslider;
    public bool maskon = false;
    public bool fson = false;
    public bool washon = false;
    int count = 0;
    int countnow = 0;
    int countfs = 0;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
        health = 5;
    }

    void Update()
    {
        if (maskon == true || fson == true) 
        {
            timemask -= Time.deltaTime;
            timefaces -= Time.deltaTime;
            maskbar();
            reset_time_mask();
            facebar();
            reset_time_fs();
            maskeffect();
        }
        
    }

 public void OnCollisionEnter2D(Collision2D obs)
    {
        if (obs.gameObject.tag == "Obstacle")
        {
            count++;
            if(maskon == true || fson == true)
            {
                switch(healthdis)
                {
                    case 1 :
                        countnow=1;
                        Debug.Log(fson);
                        break;
                    case 2 :
                        countnow=2;
                        
                        break;
                    case 3 :
                        countnow=3;
                        
                        break;
                    case 4 :
                        countnow=4;
                        
                        break;
                    case 5 :
                        countnow=5;
                        
                        break;
                }
                
            }
            else
            {
                countnow++;
            }
            

            Debug.Log(count);
    
            switch(count)
            {
                case 1 :
                    heart5.SetActive (false);
                    healthdis = 1;
                    break;
                case 2 :
                    heart4.SetActive (false);
                    healthdis = 2;
                    break;
                case 3 :
                    heart3.SetActive (false);
                    healthdis = 3;
                    break;
                case 4 :
                    heart2.SetActive (false);
                    healthdis = 4;
                    break;
                case 5 :
                    heart1.SetActive (false);
                    healthdis = 5;
                    gameoveron();
                    timestop();
                    Destroy(gameObject);
                    count = 0;
                    break;
            }
        }
    }
    //stop waktu ketika gameover
    public void timestop()
    {
        Time.timeScale = 0;
        
    }
    //nyalain gameoverscreen
    public void gameoveron()
    {
        GameOverScreen.gameObject.SetActive(true);
        bgm.Stop();
        sfxgameover.Play();
    }
//item attributes
    public void OnTriggerEnter2D(Collider2D item)
    {
        if(item.gameObject.tag == "Mask")//masker
        {
            maskon = true;
            timemask = 3f;
        }

        if(item.gameObject.tag == "FaceShield")//faceshield
        {
            fson = true;
            timefaces = 3f;
            Debug.Log("faceshield");
        }
       
        if(item.gameObject.tag == "WashHand")//checkpoint
        {
            count = 0;
            countnow = 0;
            healthdis = 0;
            heart5.SetActive (true);
            heart4.SetActive (true);
            heart3.SetActive (true);
            heart2.SetActive (true);
            heart1.SetActive (true);
            washon=true;
            sfxwash.Play();
        }

        if(item.gameObject.tag == "HandSanitizer")//handsanitizer
        {
            anim.SetBool("Semprot",true);
            hssfx.Play();
            hsdistance.gameObject.SetActive (true);
        }
    }
    //buat nunjukkin kalo waktu maskernya dah abis
    void reset_time_mask()
    {
        if(timemask < 0)
        {
            timemask = 0;
            maskon = false;
            Debug.Log("reset time");
        }
    }
    //slider waktu maskernya
    public void maskbar()
    {
        maskslider.value = timemask;
    }
    //efek maskernya
    public void maskeffect()
    {
        if (maskon == true)
        {
            if(count == 0)
            {
                count= 10;
            }
            else
            {
                count = 10;
            }
        }
        else if (maskon == false)
        {
            if(fson == false)
            {
             count = countnow;
            }
        }
         if (fson == true)
        {
            if(count == 0)
            {
                count= 10;
            }
            else
            {
                count = 10;
            }
        }
        else if (fson == false)
        {
            if(maskon == false)
            {
                count = countnow;
            }
        }

    }
    //checkpoint
    public void washhand()
    {
       // if(washon=true)
        //{
            washplace.gameObject.SetActive(false);
        //}    
    }

    //faceshield
    //slider buat faceshield
     public void facebar()
    {
        fsslider.value = timefaces;
    }

     void reset_time_fs()
    {
        if(timefaces < 0)
        {
            timefaces = 0;
            fson = false;
            Debug.Log("reset fs");
        }
    }

}



