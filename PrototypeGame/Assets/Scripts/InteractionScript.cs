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
    private bool opened = false;
    private Animator anim;

    void Start()
    {

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
        RaycastHit doorhit;
        if (Physics.Raycast(Player.transform.position, Player.transform.forward, out doorhit, MaxDistance))
        {
            // if raycast hits, then it checks if it hit an object with the tag Door.

            for (int i = 0; i < door.Length; i++)
            {
                if (doorhit.collider.name == door[i].name)
                {
                    doorScript[i] = door[i].GetComponent<DoorScript>();
                    if (doorScript[i].locked == true && doorScript[i].keyunlocked == true)
                    {
                        //This line will get the Animator from  Parent of the door that was hit by the raycast.
                        anim = doorhit.transform.GetComponentInParent<Animator>();

                        //This will set the bool the opposite of what it is.
                        opened = !opened;

                        //This line will set the bool true so it will play the animation.
                        anim.SetBool("Opened", !opened);
                        Debug.Log("DOOR OPNENED!");
                    }
                    else if (doorScript[i].locked == false && doorScript[i].keyunlocked == false)
                    {
                        anim = doorhit.transform.GetComponentInParent<Animator>();

                        //This will set the bool the opposite of what it is.
                        opened = !opened;

                        //This line will set the bool true so it will play the animation.
                        anim.SetBool("Opened", !opened);
                        Debug.Log("DOOR OPNENED!");
                    }
                    else if (doorScript[i].locked == true && doorScript[i].keyunlocked == false)
                    {
                        Debug.Log("DOOR IS LOCKED!");
                    }
                }
            }
            if (doorhit.collider.tag == "Notes")
            {
                Debug.Log("Opened");
                doorhit.collider.GetComponent<Notes>().ShowNotes();
                opened = !opened;
            }
        }
    }
}
