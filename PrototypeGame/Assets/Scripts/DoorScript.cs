using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public bool keyunlocked = false;
    public bool locked;
    public Text lockText;
   

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key") && locked == true)
        {
            //Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Debug.Log("DOOR CAN NOW BE UNLOCKED!");
            //lockText.text = "Door is Unlocked";
            keyunlocked = true;
            
            
            
        }
    }
    
}
