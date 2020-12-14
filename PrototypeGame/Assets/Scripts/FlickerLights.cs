using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLights : MonoBehaviour
{
    bool isOn = false;
    float flickerDelay;

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
            StartCoroutine(FlickeringLights());
        }
    }

    IEnumerator FlickeringLights()
    {
        isOn = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        flickerDelay = Random.Range(0.1f, 0.3f);
        yield return new WaitForSeconds(flickerDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        flickerDelay = Random.Range(0.1f, 0.3f);
        yield return new WaitForSeconds(flickerDelay);
        isOn = false;
    }
}

