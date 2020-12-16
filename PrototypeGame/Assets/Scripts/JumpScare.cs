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

    private Animator jumpscareAnimator;

    public InteractionScript interaction;
    public GameObject noteImage;

    // Start is called before the first frame update
    void Start()
    {
        jumpscare.SetActive(false);
        jumpscare2.SetActive(false);
        jumpscare3.SetActive(false);
    }

    private void Update()
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
            StartCoroutine(DestroyGirl());
        }

        if (player.tag == "Player" && this.gameObject.name == "NoteJumpScareTrigger" && interaction.startScare == true && noteImage.activeInHierarchy == false)
        {
            StartCoroutine(DestroyNun());
            interaction.startScare = false;
        }

        if (player.tag == "Player" && this.gameObject.name == "NunCorridorJumpscareTrigger")
        {
            StartCoroutine(NunJumpscare2());
        }
    }

    IEnumerator DestroyGirl()
    {
        jumpscare.SetActive(true);
        jumpscareAnimator = jumpscare.GetComponent<Animator>();
        jumpscareAnimator.SetBool("Opened", true);
        yield return new WaitForSeconds(3.2f);
        Destroy(jumpscare);
        Destroy(this.gameObject);
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
        yield return new WaitForSeconds(0.45f);
        Destroy(jumpscare3);
        Destroy(this.gameObject);
    }


    //private void JumpScareTest()
    //{
    //    FindObjectOfType<AudioManager>().Play("JumpScare1");

    //    RaycastHit hit;
    //    if (Physics.Raycast(FindObjectOfType<Camera>().transform.position, FindObjectOfType<Camera>().transform.forward, out hit, 10f))
    //    {
    //        if (hit.collider.tag == "JumpScare")
    //        {
    //            Destroy(jumpscare2);
    //            Destroy(this.gameObject);
    //        }
    //    }
    //}
}
    