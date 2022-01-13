using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoint;
    public GameObject[] hazards;
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
public float minTimeBetweenSpawns;
public float decrease;
public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(player!=null){
        if(timeBtwSpawns<=0){
            Transform randomspot=spawnPoint[Random.Range(0,spawnPoint.Length)];
            GameObject randomHazards=hazards[Random.Range(0,hazards.Length)];
            Instantiate(randomHazards,randomspot.position,Quaternion.identity);
            if(startTimeBtwSpawns>minTimeBetweenSpawns){
                startTimeBtwSpawns-=decrease;

            }
            timeBtwSpawns=startTimeBtwSpawns;

        }else{
            timeBtwSpawns-=Time.deltaTime;

        }
    }
    }
}
