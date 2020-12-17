using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public Animator[] door;
    public GameObject jumpscare;
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

    public GameObject player;
    public GameObject playercamera;
    public GameObject headbob;

    public bool isOn = false;
    float flickerDelay;

    // Start is called before the first frame update
    void Start()
    {
        jumpscare.SetActive(false);
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
            StartCoroutine(NunJumpscare2());
            //StartCoroutine(VisionDisable());
        }

        if (player.tag == "Player" && this.gameObject.name == "LightFlickerTrigger")
        {
            isOn = true;
            StartCoroutine(SpookyAudio());
        }

        if (player.tag == "Player" && this.gameObject.name == "GirlTwistJumpScareTrigger" && interaction.startScare == true && noteImage.activeInHierarchy == false)
        {
            StartCoroutine(GirlJumpscare());
            interaction.startScare = false;
            grain.enabled.value = true;
        }
    }

    IEnumerator DestroyNun()
    {
        FindObjectOfType<AudioManager>().Play("JumpScare1");
        yield return new WaitForSeconds(0.7f);
        Destroy(jumpscare2);
        Destroy(this.gameObject);
    }

    IEnumerator GirlJumpscare()
    {
        FindObjectOfType<AudioManager>().Play("necktwist"); 
        player.GetComponent<CharacterController>().enabled = false;
        playercamera.GetComponent<CameraController>().enabled = false;
        headbob.GetComponent<HeadBob>().enabled = false;
        jumpscare.SetActive(true);
        jumpscareAnimator = jumpscare.GetComponent<Animator>();
        jumpscareAnimator.SetBool("Opened", true);
        yield return new WaitForSeconds(7f);
        FindObjectOfType<AudioManager>().Play("heartbeat");
        jumpscare.SetActive(false);
        player.GetComponent<CharacterController>().enabled = true;
        playercamera.GetComponent<CameraController>().enabled = true;
        headbob.GetComponent<HeadBob>().enabled = true;
        Destroy(this.gameObject);
    }

    IEnumerator NunJumpscare2()
    {
        this.gameObject.GetComponent<Collider>().enabled = false;
        FindObjectOfType<AudioManager>().Play("JumpScare2");
        grain.enabled.value = true;
        lensDistortion.enabled.value = true;
        colorGrading.enabled.value = true;
        jumpscare3.SetActive(true);
        jumpscareAnimator = jumpscare3.GetComponent<Animator>();
        jumpscareAnimator.SetBool("Opened", true);
        yield return new WaitForSeconds(1.01f);
        jumpscare3.SetActive(false);
        yield return new WaitForSeconds(10);
        grain.enabled.value = false;
        lensDistortion.enabled.value = false;
        colorGrading.enabled.value = false;
        this.gameObject.SetActive(false);
    }

    //IEnumerator VisionDisable()
    //{

    //}

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
    