using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPacked; // değer atamamak false olarak başlatmaktır!!
    bool hasDelivered;
    
    
    void OnCollisionEnter2D(Collision2D other){

       // Debug.Log("Ohh..It Hurtsssss...!!!");
        
    }

    
   void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Package" && !hasPacked){
            hasPacked = true;
            hasDelivered = false;
            Debug.Log("Package picked up!!!");
            Destroy(other.gameObject);
        }else if(other.tag == "Customer" && hasPacked && !hasDelivered){
            Debug.Log("Customer: Thanksss..");
            hasPacked = false;
            hasDelivered = true;
        }
       
    }


}
