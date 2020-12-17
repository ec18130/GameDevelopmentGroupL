using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpUI : MonoBehaviour
{
    public Transform Player;
    public Camera Camera;
    float MaxDistance = 2.5f;
    public GameObject handUI;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.GetComponent<Transform>().transform.position, Camera.GetComponent<Transform>().transform.forward, out hit, MaxDistance))
        {
            if (hit.collider.tag == "Notes")
            {
                Debug.Log("Looking");
                handUI.SetActive(true);
            }
            else if (hit.collider.tag == "Battery")
            {
                handUI.SetActive(true);
            }
            else if (hit.collider.tag == "Key")
            {
                handUI.SetActive(true);
            }
            else if (hit.collider.tag == "Door")
            {
                handUI.SetActive(true);
            }
            else if (hit.collider.tag == "Elevator")
            {
                handUI.SetActive(true);
            }
            else if (hit.collider.tag == "TV")
            {
                handUI.SetActive(true);
            }
            else
            {
                handUI.SetActive(false);
            }
        }
    }
}
