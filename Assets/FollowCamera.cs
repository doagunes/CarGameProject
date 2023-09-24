using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // this thing (camera) position should be the same as the car's position!!!
    
    [SerializeField] GameObject thingsToFollow;
    void LateUpdate() //kamera takip sistemlerinde kullanılır
    {
        transform.position = thingsToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
