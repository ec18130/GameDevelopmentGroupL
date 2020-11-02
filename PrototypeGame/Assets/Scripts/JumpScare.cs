using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject jumpscare;
    // Start is called before the first frame update
    void Start()
    {
        jumpscare.SetActive(true);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player")
        {
            StartCoroutine(DestroyObject());
        }
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(0.5f);
        jumpscare.SetActive(true);
        jumpscare.GetComponent<Rigidbody>().AddForce(Vector3.right * 600f);
        yield return new WaitForSeconds(2.5f);
        Destroy(jumpscare);
        Destroy(gameObject);
    }
}
