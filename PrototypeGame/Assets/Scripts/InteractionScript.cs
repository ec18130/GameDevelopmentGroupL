using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    public Transform Player;
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 5;
    public DoorScript[] doorScript;
    public GameObject[] door;
    public GameObject block;
    private bool opened = false;
    private bool isPressed;
    private Animator anim;
    public Animator[] lift;
    public Text lockText;
    //private AudioSource source;


    void Start()
    {
        
        //lockText.text = "";
    }

    void Update()
    {
        //This will tell if the player press F on the Keyboard. P.S. You can change the key if you want.
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pressed();
        }
    }

    void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit hit;
        if (Physics.Raycast(Player.transform.position, Player.transform.forward, out hit, MaxDistance))
        {
            // if raycast hits, then it checks if it hit an object with the tag Door.
            for (int i = 0; i < door.Length; i++)
            {
                if (hit.collider.tag == door[i].tag)
                {
                    doorScript[i] = door[i].GetComponent<DoorScript>();
                    if (doorScript[i].locked == true && doorScript[i].keyunlocked == true)
                    {
                        //This line will get the Animator from  Parent of the door that was hit by the raycast.
                        anim = hit.transform.GetComponentInParent<Animator>();

                        //This will set the bool the opposite of what it is.
                        opened = !opened;

                        //This line will set the bool true so it will play the animation.
                        anim.SetBool("Opened", opened);
                        if (door[i].tag == "ElevatorLock")
                        {
                            Destroy(block);
                        }
                        //source = GetComponentInParent<AudioSource>();
                        isPressed = !isPressed;
                        Debug.Log("DOOR OPNENED!");
                        //source.Play();

                    }
                    else if (doorScript[i].locked == false && doorScript[i].keyunlocked == false)
                    {
                        anim = hit.transform.GetComponentInParent<Animator>();

                        //This will set the bool the opposite of what it is.
                        opened = !opened;

                        //This line will set the bool true so it will play the animation.
                        anim.SetBool("Opened", opened);
                        //source = GetComponentInParent<AudioSource>();
                        //source.Play();
                    }
                    else if (doorScript[i].locked == true && doorScript[i].keyunlocked == false)
                    {
                        Debug.Log("DOOR IS LOCKED!");
                        //lockText.text = "Door is locked";
                        //source = GetComponentInParent<AudioSource>();
                       // source.Play();
                    }
                }
            }
            if (hit.collider.tag == "Notes")
            {
                Debug.Log("Opened");
                hit.collider.GetComponent<Notes>().ShowNotes();
                opened = !opened;
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
        }
    }
}
