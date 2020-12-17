using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVeffect : MonoBehaviour
{
    public VideoPlayer video;
    public Material tvmaterial;
    public AudioSource source;
    public GameObject tvlight;

    private void OnTriggerEnter(Collider other)
    {
        tvlight.SetActive(true);
        video.Play();
        source.Play();
        tvmaterial.EnableKeyword("_EMISSION");
        Destroy(this.gameObject);
    }
}