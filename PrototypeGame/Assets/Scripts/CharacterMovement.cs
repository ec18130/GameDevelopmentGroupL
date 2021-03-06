﻿using System.Collections;
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

    public InteractionScript interactionScript;

    public GameObject Light;
    bool lightState;

    private float maxBattery;
    private float currentBattery;
    private int batteries = 1;
    private float usedBattery;

    public Text Batterytext;

    [SerializeField]
    private int FlashlightOffDuration;

    // Start is called before the first frame update
    void Start()
    {
        lightState = false;
        currentBattery = maxBattery;
        maxBattery = 50 * batteries;
    }

    void Update()
    {
        maxBattery = 50 * batteries;
        currentBattery = maxBattery - usedBattery;

        int value = (int)Mathf.Round(currentBattery);

        Batterytext.text = "Flashlight: " + value.ToString() + "%";

        print("battery used: " + usedBattery);

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

        if (Input.GetKeyDown(KeyCode.F))
        {
            lightState = !lightState;
            FindObjectOfType<AudioManager>().Play("FlashlightOn");
        }

        if (lightState == true)
        {
            Debug.Log("Flash Light on!");
            Light.SetActive(true);

            if (currentBattery <= 0)
            {
                Light.SetActive(false);
                FlashlightOffDuration++;
                batteries = 0;
            }
            else if (currentBattery > 0)
            {
                Light.SetActive(true);
                currentBattery -= 0.25f * Time.deltaTime;
                usedBattery += 0.25f * Time.deltaTime;
                FlashlightOffDuration--;
            }
            if (usedBattery >= 50)
            {
                batteries -= 1;
                usedBattery = 0;
                FlashlightOffDuration--;
            }
        }
        else if (lightState == false)
        {
            Light.SetActive(false);
            Debug.Log("Flash Light off!");
            FlashlightOffDuration++;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            interactionScript.Pressed();
            if (interactionScript.batteryPickup == true)
            {
                batteries += 1;
                interactionScript.batteryPickup = !interactionScript.batteryPickup;
            }
        }
    }
}
