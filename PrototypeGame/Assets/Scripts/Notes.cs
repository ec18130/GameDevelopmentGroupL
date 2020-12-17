using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notes : MonoBehaviour
{
    public Image NotesImage;
    public GameObject player;
    public GameObject playercamera;
    public GameObject headbob;
    public GameObject closeButton;

    public bool beginJumpscare = false;


    // Start is called before the first frame update
    void Start()
    {
        NotesImage.enabled = false;
        closeButton.SetActive(false);
    }

    public void ShowNotes()
    {
        NotesImage.enabled = true;
        closeButton.SetActive(true);
        player.GetComponent<CharacterController>().enabled = false;
        playercamera.GetComponent<CameraController>().enabled = false;
        headbob.GetComponent<HeadBob>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseNotes()
    {
        NotesImage.enabled = false;
        closeButton.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.GetComponent<CharacterController>().enabled = true;
        playercamera.GetComponent<CameraController>().enabled = true;
        headbob.GetComponent<HeadBob>().enabled = true;
    }
}
