using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    float counter = 0.0f;
    
    void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Ohh..It Hurtsssss...!!!");
        
    }

    
   void OnTriggerEnter2D(Collider2D other) {
        counter++;
        Debug.Log("You Got Coinnnn!!!");
       
    }


}
