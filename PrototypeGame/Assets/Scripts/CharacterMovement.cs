using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;

    public Vector3 velocity;
    public float gravity = -9.81f;

    public Transform checkFloor;
    public float floorDistance = 0.4f;
    public LayerMask floorMask;
    bool isGrounded;
    public GameObject Light;
    bool lightState;
   

    // Start is called before the first frame update
    void Start()
    {
        lightState = false;
      
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(checkFloor.position, floorDistance, floorMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        } 

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 movement = transform.right * x + transform.forward * z;

        controller.Move(movement * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.F) && lightState == false)
        {
            Light.SetActive(true);
            lightState = true;
            Debug.Log("Flash Light on!");
        }
        else if (Input.GetKeyDown(KeyCode.F) && lightState != false)
        {
            Light.SetActive(false);
            lightState = false;
            Debug.Log("Flash Light off!");
        }

    }

    
}
