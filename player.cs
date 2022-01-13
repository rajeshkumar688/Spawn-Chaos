using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject looseScreen;
    Rigidbody2D rb;
    Animator anim;
    public int health;
    public float speed;
    private float input;
    public Text healthDisplay;
   public AudioSource source;

    void Start()
    {
        source=GetComponent<AudioSource>();

        anim=GetComponent<Animator>();

        rb=GetComponent<Rigidbody2D>();
        healthDisplay.text=health.ToString();
    }

    private void Update() {
        
        if(input !=0){
            anim.SetBool("isRunning",true);

        }
        else{
            anim.SetBool("isRunning",false);
        }
        if(input>0){
            transform.eulerAngles=new Vector3(0,0,0);

        }
        else if(input<0){
            transform.eulerAngles=new Vector3(0,180,0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        input=Input.GetAxisRaw("Horizontal");
        rb.velocity=new Vector2(input*speed,rb.velocity.y);

    }
    public void TakeDamage(int damageAmount){
        source.Play();
        health-=damageAmount;
        healthDisplay.text=health.ToString();
        if(health<=0){
            looseScreen.SetActive(true);
            Destroy(gameObject);
        }
    }
}
