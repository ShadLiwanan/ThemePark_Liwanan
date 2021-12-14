using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovementScript : MonoBehaviour
{
    
    public float speedHorizontal = 2.0f;
    public float speedVertical = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;


    void Start()
    {
        
    }

    
     public float speed = 5.0f; 
 void Update()
 {
    //Camera WASD Movement     
     if(Input.GetKey(KeyCode.D))
     {
         transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
     }
     if(Input.GetKey(KeyCode.A))
     {
         transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
     }
     if(Input.GetKey(KeyCode.S))
     {
         transform.position += transform.forward * -speed *Time.deltaTime;
     }
     if(Input.GetKey(KeyCode.W))
     {
        transform.position += transform.forward * speed *Time.deltaTime;
     }

    //Camera Rotation with Mouse

    yaw += speedHorizontal * Input.GetAxis("Mouse X");
    pitch -= speedVertical * Input.GetAxis("Mouse Y");

    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

 }
}