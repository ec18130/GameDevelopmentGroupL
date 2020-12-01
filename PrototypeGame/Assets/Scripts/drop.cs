using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drop : MonoBehaviour
{
    public float collectCounter;
    public float numPickups;
    public Text winText;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        numPickups = 2;
        collectCounter = 0;
        winText.text = "";
        SetCountText();
    }

    void OnTriggerEnter(Collider pickUpObject)
    {
        if (pickUpObject.tag == "PickUpObject")
        {
            Destroy(pickUpObject);
            //StartCoroutine(DestroyObject());
            collectCounter++;
            Debug.Log("yea");
            Debug.Log(collectCounter);
            SetCountText();
        }
    }
    private void SetCountText()
    {
        scoreText.text = "Score: " + collectCounter.ToString();
        if (collectCounter >= numPickups)
        {
            winText.text = "You win!";
        }
    }

}
