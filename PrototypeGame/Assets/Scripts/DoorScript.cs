using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool keyunlocked = false;
    public bool locked;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key") && locked == true)
        {
            //Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Debug.Log("DOOR CAN NOW BE UNLOCKED!");
            keyunlocked = true;
        }
    }
}
