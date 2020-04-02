using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    // Start is called before the first frame update
    //public int speed=20;
    public int speed = 30;

    public Rigidbody2D sesuatu;

    public Animator animtr;

    void Start()
    {
        //Debug.Log("Hello Word");
        //GetComponent<Rigidbody2D>().velocity = new Vector2 (1,1) * speed;
        sesuatu.velocity = new Vector2(-1,-1) * speed;
        animtr.SetBool("IsmMove" , true);
    }

    // Update is called once per frame
    //void FixedUpdate()
    void FixedUpdate()
    {
        if(sesuatu.velocity.x > 0){ //bola bergerak ke-kanan
            sesuatu.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);

        }else{
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);  
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
      if(other.collider.name == "Wallkanan" || other.collider.name == "WallKiri"){
          GetComponent<Transform>().position = new Vector2 (0,0);
              StartCoroutine(jeda());
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

