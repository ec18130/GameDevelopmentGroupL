using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public bool keyunlocked = false;
    public bool locked;
    public Text lockText;
    public GameObject unlockTextObj;

    void Start()
    {

        
        unlockTextObj.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key") && locked == true)
        {
            //Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Debug.Log("DOOR CAN NOW BE UNLOCKED!");
            //lockText.text = "Door is Unlocked";
            keyunlocked = true;
            unlockTextObj.SetActive(true);
            StartCoroutine("WaitForSec");


        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        unlockTextObj.SetActive(false);

    }
}
