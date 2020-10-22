using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1.0f;

    public Vector3 velocity;
    public float gravity = -9.81f;

    public Transform checkFloor;
    public float floorDistance = 0.4f;
    public LayerMask floorMask;
    bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
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
    }

}
