using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float movementSpeed = 10;
    public float turningSpeed = 80;
    
    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
         
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
