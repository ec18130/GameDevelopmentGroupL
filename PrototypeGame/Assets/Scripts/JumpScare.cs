using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public Animator[] door;
    public GameObject jumpscare2;
    public GameObject jumpscare3;
    public GameObject jumpscare4;

    private Animator jumpscareAnimator;

    public InteractionScript interaction;
    public GameObject noteImage;

    public PostProcessVolume volume;
    private Grain grain = null;
    private ColorGrading colorGrading = null;
    private LensDistortion lensDistortion = null;

    public bool isOn = false;
    float flickerDelay;

    // Start is called before the first frame update
    void Start()
    {
        jumpscare2.SetActive(false);
        jumpscare3.SetActive(false);
        jumpscare4.SetActive(false);
        volume.profile.TryGetSettings(out grain);
        volume.profile.TryGetSettings(out colorGrading);
        volume.profile.TryGetSettings(out lensDistortion);
    }

    void Update()
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
        else if (player.tag == "Player" && this.gameObject.name == "GirlJumpScareTrigger")
        {
            FindObjectOfType<AudioManager>().Play("Hi");
        }

        if (player.tag == "Player" && this.gameObject.name == "NoteJumpScareTrigger" && interaction.startScare == true && noteImage.activeInHierarchy == false)
        {
            StartCoroutine(DestroyNun());
            interaction.startScare = false;
        }

        if (player.tag == "Player" && this.gameObject.name == "NunCorridorJumpscareTrigger")
        {
            StartCoroutine(VisionDisable());
            StartCoroutine(NunJumpscare2());
        }

        if (player.tag == "Player" && this.gameObject.name == "LightFlickerTrigger")
        {
            isOn = true;
            StartCoroutine(SpookyAudio());
        }
    }

    IEnumerator DestroyNun()
    {
        FindObjectOfType<AudioManager>().Play("JumpScare1");
        jumpscare2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Destroy(jumpscare2);
        Destroy(this.gameObject);
    }

    IEnumerator NunJumpscare2()
    {
        FindObjectOfType<AudioManager>().Play("JumpScare2");
        jumpscare3.SetActive(true);
        jumpscareAnimator = jumpscare3.GetComponent<Animator>();
        jumpscareAnimator.SetBool("Opened", true);
        yield return new WaitForSeconds(1.01f);
        Destroy(jumpscare3);
    }

    IEnumerator VisionDisable()
    {
        grain.enabled.value = true;
        lensDistortion.enabled.value = true;
        colorGrading.enabled.value = true;
        yield return new WaitForSeconds(10);
        grain.enabled.value = false;
        lensDistortion.enabled.value = false;
        colorGrading.enabled.value = false;
        this.gameObject.SetActive(false);
    }

    IEnumerator SpookyAudio()
    {
        FindObjectOfType<AudioManager>().Play("JumpScare3");
        jumpscare4.SetActive(true);
        jumpscareAnimator = jumpscare4.GetComponent<Animator>();
        jumpscareAnimator.SetBool("Opened", true);
        yield return new WaitForSeconds(2.0f);
        isOn = false;
        Destroy(jumpscare4);
        Destroy(this.gameObject);
    }
}
    