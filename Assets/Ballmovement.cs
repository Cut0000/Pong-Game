using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    // Start is called before the first frame update
    //public int speed=20;
    public int speed = 30;

    public Rigidbody2D sesuatu;

    void Start()
    {
        //Debug.Log("Hello Word");
        //GetComponent<Rigidbody2D>().velocity = new Vector2 (1,1) * speed;
        sesuatu.velocity = new Vector2(-1,-1) * speed;

    }

    // Update is called once per frame
    //void FixedUpdate()
    void Update()
    {

        //Update is called once per frame void Fixed update
    }

    void OnCollisionEnter2D(Collision2D other) {
      if(other.collider.name == "Wallkanan" || other.collider.name == "WallKiri"){
          GetComponent<Transform>().position = new Vector2 (0,0);
        
        }
    }
}