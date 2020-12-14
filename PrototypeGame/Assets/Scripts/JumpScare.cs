using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public Animator[] door;
    public GameObject jumpscare;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player" && this.gameObject.name == "MainDoorCloseTrigger")
        {
            FindObjectOfType<AudioManager>().Play("Doorshut");
            for (int i = 0; i < door.Length; i++)
            {
                door[i].SetBool("Opened", false);
                Debug.Log("Front door closed");
            }
            Destroy(this.gameObject);
        }
        else if (player.tag == "Player" && this.gameObject.name == "Test")
        {
            StartCoroutine(DestroyObject());
            FindObjectOfType<AudioManager>().Play("Hi");
        }
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(0.5f);
        jumpscare.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        Destroy(jumpscare);
        Destroy(this.gameObject);
    }
}
