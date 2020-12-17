using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLights : MonoBehaviour
{
    public Material lightMaterialChange;
    public GameObject lamp;
    public JumpScare JumpScare;
    float flickerDelay;

    // Update is called once per frame
    void Update()
    {
        if (JumpScare.isOn == true)
        {
            StartCoroutine(FlickeringLights());
        }
    }

    IEnumerator FlickeringLights()
    {
        this.gameObject.GetComponent<Light>().enabled = false;
        flickerDelay = Random.Range(0.1f, 0.3f);
        yield return new WaitForSeconds(flickerDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        flickerDelay = Random.Range(0.1f, 0.3f);
        yield return new WaitForSeconds(flickerDelay);

        if (JumpScare.isOn == false)
        {
            lamp.GetComponent<MeshRenderer>().material = lightMaterialChange;
            Destroy(this.gameObject);
        }
    }
}

