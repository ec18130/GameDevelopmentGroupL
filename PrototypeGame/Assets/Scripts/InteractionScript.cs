﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    public Transform Player;
    public Camera Camera;
    [Header("MaxDistance you can open or close the door.")]
    float MaxDistance = 2.5f;
    private bool opened = false;
    private bool isPressed;
    private Animator anim;
    public Animator[] lift;
    public Text lockText;
    private AudioSource source;
    public GameObject lockTextObj;

    public GameObject door_1;
    public GameObject door_2;
    public GameObject door_3;
    public GameObject door_4;
    public GameObject door_5;
    public GameObject door_6;
    public GameObject door_7;
    public GameObject door_8;
    public GameObject door_9;
    public GameObject door_10;

    public Animator[] doubledoor;
    public GameObject DoubleDoor;

    public Animator[] doubledoor3Fl;
    public GameObject DoubleDoor3Fl;

    DoorScript doorScript;

    public GameObject Battery;
    public GameObject Battery_2;
    public GameObject Battery_3;
    public GameObject Battery_4;
    public GameObject Battery_5;
    public GameObject Battery_6;
    public bool batteryPickup;
    public bool delete;

    public TVeffect tvscript;

    public bool startScare = false;
    public GameObject GirlTwistJumpScareTrigger;

    void Start()
    {

        lockTextObj.SetActive(false);
        source = GetComponentInParent<AudioSource>();
    }

    void Update()
    {
        //This will tell if the player press E on the Keyboard. P.S. You can change the key if you want.
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.DrawRay(Camera.GetComponent<Transform>().transform.position, Camera.GetComponent<Transform>().transform.forward, Color.red, 10,false);
        }
    }

    public void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit hit;
        if (Physics.Raycast(Camera.GetComponent<Transform>().transform.position, Camera.GetComponent<Transform>().transform.forward, out hit, MaxDistance))
        {
            // if raycast hits, then it checks if it hit an object with the tag Door.

            if (hit.collider.name == door_1.name)
            {
                doorScript = door_1.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_2.name)
            {
                doorScript = door_2.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_3.name)
            {
                doorScript = door_3.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_4.name)
            {
                doorScript = door_4.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_5.name)
            {
                doorScript = door_5.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_6.name)
            {
                doorScript = door_6.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_7.name)
            {
                doorScript = door_7.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_8.name)
            {
                doorScript = door_8.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_9.name)
            {
                doorScript = door_9 .GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            else if (hit.collider.name == door_10.name)
            {
                doorScript = door_10.GetComponent<DoorScript>();

                if (doorScript.locked == true && doorScript.keyunlocked == true)
                {
                    //This line will get the Animator from  Parent of the door that was hit by the raycast.
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }
                else if (doorScript.locked == false && doorScript.keyunlocked == false)
                {
                    anim = hit.transform.GetComponentInParent<Animator>();

                    //This will set the bool the opposite of what it is.
                    opened = !opened;
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("Opened", opened);
                    Debug.Log("DOOR OPNENED!");
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                }

                else if (doorScript.locked == true && doorScript.keyunlocked == false)
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
                else
                {
                    Debug.Log("DOOR IS LOCKED!");
                    lockTextObj.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("DoorOpen");
                    StartCoroutine("WaitForSec");
                    anim = hit.transform.GetComponentInParent<Animator>();
                    anim.SetBool("Opened", false);
                }
            }

            if (hit.collider.tag == "DoubleDoor")
            {
                if (hit.collider.name == "3FHallDoor")
                {
                    doorScript = DoubleDoor3Fl.GetComponent<DoorScript>();

                    if (doorScript.locked == true && doorScript.keyunlocked == true)
                    {
                        isPressed = !isPressed;
                        for (int i = 0; i < doubledoor3Fl.Length; i++)
                        {
                            doubledoor3Fl[i].SetBool("Opened", isPressed);
                        }
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }
                    else if (doorScript.locked == false && doorScript.keyunlocked == false)
                    {
                        isPressed = !isPressed;
                        for (int i = 0; i < doubledoor3Fl.Length; i++)
                        {
                            doubledoor3Fl[i].SetBool("Opened", isPressed);
                        }
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }

                    else if (doorScript.locked == true && doorScript.keyunlocked == false)
                    {
                        Debug.Log("DOOR IS LOCKED!");
                        lockTextObj.SetActive(true);
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }
                    else
                    {
                        Debug.Log("DOOR IS LOCKED!");
                        lockTextObj.SetActive(true);
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }
                }
                else if (hit.collider.name == "2FHall_Door")
                {
                    doorScript = DoubleDoor.GetComponent<DoorScript>();

                    if (doorScript.locked == true && doorScript.keyunlocked == true)
                    {
                        isPressed = !isPressed;
                        for (int i = 0; i < doubledoor.Length; i++)
                        {
                            doubledoor[i].SetBool("Opened", isPressed);
                        }
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }
                    else if (doorScript.locked == false && doorScript.keyunlocked == false)
                    {
                        isPressed = !isPressed;
                        for (int i = 0; i < doubledoor.Length; i++)
                        {
                            doubledoor[i].SetBool("Opened", isPressed);
                        }
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }

                    else if (doorScript.locked == true && doorScript.keyunlocked == false)
                    {
                        Debug.Log("DOOR IS LOCKED!");
                        lockTextObj.SetActive(true);
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }
                    else
                    {
                        Debug.Log("DOOR IS LOCKED!");
                        lockTextObj.SetActive(true);
                        FindObjectOfType<AudioManager>().Play("DoorOpen");
                        StartCoroutine("WaitForSec");
                    }
                }
            }


            if (hit.collider.tag == "Notes")
            {
                Debug.Log("Opened");
                FindObjectOfType<AudioManager>().Play("Notes");
                hit.collider.GetComponent<Notes>().ShowNotes();
                opened = !opened;

                if (hit.collider.name == "Note3")
                {
                    startScare = true;
                }
                if (hit.collider.name == "Note4")
                {
                    GirlTwistJumpScareTrigger.SetActive(true);
                    startScare = true;
                }
                if (hit.collider.name == "Note6")
                {
                    startScare = true;
                }
            }
            else if (hit.collider.tag == "Elevator")
            {
                isPressed = !isPressed;
                for (int i = 0; i < lift.Length; i++)
                {
                    lift[i].SetBool("Opened", isPressed);
                    Debug.Log("Elevator Opened");
                }
            }

            else if (hit.collider.name == Battery.name)
            {
                FindObjectOfType<AudioManager>().Play("Batteries");
                batteryPickup = true;
                Battery.SetActive(false);
            }
            else if (hit.collider.name == Battery_2.name)
            {
                FindObjectOfType<AudioManager>().Play("Batteries");
                batteryPickup = true;
                Battery_2.SetActive(false);
            }
            else if (hit.collider.name == Battery_3.name)
            {
                FindObjectOfType<AudioManager>().Play("Batteries");
                batteryPickup = true;
                Battery_3.SetActive(false);
            }
            else if (hit.collider.name == Battery_4.name)
            {
                FindObjectOfType<AudioManager>().Play("Batteries");
                batteryPickup = true;
                Battery_4.SetActive(false);
            }

            else if (hit.collider.name == Battery_5.name)
            {
                FindObjectOfType<AudioManager>().Play("Batteries");
                batteryPickup = true;
                Battery_5.SetActive(false);
            }

            else if (hit.collider.name == Battery_6.name)
            {
                FindObjectOfType<AudioManager>().Play("Batteries");
                batteryPickup = true;
                Battery_6.SetActive(false);
            }


            else if (hit.collider.tag == "TV")
            {
                tvscript.video.Stop();
                tvscript.source.Stop();
                tvscript.tvmaterial.DisableKeyword("_EMISSION");
                tvscript.tvlight.SetActive(false);
            }
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        lockTextObj.SetActive(false);
    }
}
