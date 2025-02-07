using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    public float movementspeed = 5f;
    public float rotateSpeed = 0.01f;

    

    void Update()
    {
        transform.position += Vector3.forward * movementspeed * Time.deltaTime;
        transform.eulerAngles += Vector3.right * rotateSpeed ;
    }

    
}
