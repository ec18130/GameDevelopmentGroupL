using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupUI : MonoBehaviour
{
    public Transform Player;
    public Camera Camera;
    float MaxDistance = 2.5f;
    public GameObject handUI;
    public GameObject Battery;
    public GameObject Battery_2;
    // Start is called before the first frame update
    void Start()
    {
        // object set active = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(Camera.GetComponent<Transform>().transform.position, Camera.GetComponent<Transform>().transform.forward, Color.red, 10, false);
        RaycastHit hit;
        if (Physics.Raycast(Camera.GetComponent<Transform>().transform.position, Camera.GetComponent<Transform>().transform.forward, out hit, MaxDistance))
        {
            if (hit.collider.tag == "Notes")
            {
                Debug.Log("Looking");
                handUI.SetActive(true);
            }
            else if (hit.collider.name == Battery.name)
            {
                handUI.SetActive(true);
            }
            else if (hit.collider.name == Battery_2.name)
            {
                handUI.SetActive(true);
            }
            else if (hit.collider.tag == "Key")
            {
                handUI.SetActive(true);
            }
            else
            {
                handUI.SetActive(false);
            }
        }
    }

    /*void Looking()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.GetComponent<Transform>().transform.position, Camera.GetComponent<Transform>().transform.forward, out hit, MaxDistance))
        {
            if (hit.collider.tag == "Notes")
            {
                Debug.Log("Looking");
                
            }       
        }
    }*/
}
