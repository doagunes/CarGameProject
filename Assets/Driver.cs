using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steeringVelocity = 300.0f;
    float rideVelocity = 20.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float steeringControl = Input.GetAxis("Horizontal") * steeringVelocity * Time.deltaTime; // hizli ve yavas bilgisayarlarda ayni sekilde calismasini saglayacak
        float rideControl = Input.GetAxis("Vertical") * rideVelocity * Time.deltaTime;

        transform.Rotate(0, 0, -steeringControl);
        transform.Translate(0, rideControl, 0);
       
        
    }
}
