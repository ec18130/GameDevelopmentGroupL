using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVeffect : MonoBehaviour
{

    public Material tvmaterial;
    public AudioSource tvaudio;

    private void OnTriggerEnter(Collider other)
    {
        tvaudio.Play();
        tvmaterial.EnableKeyword("_EMISSION");
        Destroy(this.gameObject);
    }
}
