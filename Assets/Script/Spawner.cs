using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnpoint;
    public GameObject[] obs;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D spawn)
    {
        int randEnemy = Random.Range(0, obs.Length);
        int randspawnpoint = Random.Range(0, spawnpoint.Length);

        if(spawn.gameObject.tag == "Respawn")
        {
            Instantiate(obs[randEnemy],spawnpoint[randspawnpoint].position,transform.rotation);
        }
    }
}
