using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    // Start is called before the first frame update
   
    public int speed = 30;
    public Rigidbody2D sesuatu;
    public  GameObject masterScript;
    public Animator animtr;
    public AudioSource hitEffect;

    void Start()
    {
        sesuatu.velocity = new Vector2(-1,-1) * speed;
        animtr.SetBool("IsMove" , true);
    }
    
    void FixedUpdate()
   {
        if(sesuatu.velocity.x > 0){ //bola bergerak ke-kanan
            sesuatu.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);

       }else{
           sesuatu.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);  
       }
   }

    void OnCollisionEnter2D(Collision2D other) {
      if(other.collider.name == "Tembokkanan" || other.collider.name == "Tembokkiri"){
        masterScript.GetComponent<ScoringScript>().UpdateScore(other.collider.name);
        StartCoroutine(jeda());
        }
        if(other.collider.tag=="Player"){
            hitEffect.Play();
        }
    }

    IEnumerator jeda(){
        sesuatu.velocity = Vector2.zero;
        animtr.SetBool("IsMove", false);
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);
        sesuatu.velocity = new Vector2(-1, -1) * speed;
        animtr.SetBool("IsMove", true);
     }
}


