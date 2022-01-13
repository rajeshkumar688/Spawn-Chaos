using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    private float speed;
    player playerscript;
    public int damage;
    public GameObject explosion;
    void Start()

    {
        speed=Random.Range(minSpeed,maxSpeed);
        playerscript=GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.down*speed*Time.deltaTime); 
    }
    private void OnTriggerEnter2D(Collider2D hitObject) {
        if(hitObject.tag=="Player"){
         Instantiate(explosion,transform.position,Quaternion.identity);
          playerscript.TakeDamage(damage);
          Destroy(gameObject);
        }
        if(hitObject.tag=="Ground"){
            Destroy(gameObject);
            Instantiate(explosion,transform.position,Quaternion.identity);
        }
        

    }
}

