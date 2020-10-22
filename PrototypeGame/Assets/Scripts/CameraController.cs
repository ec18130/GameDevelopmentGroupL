using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSpeed = 100f;
    public Transform player;
    float xrotate = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
        xrotate -= mouseY;
        xrotate = Mathf.Clamp(xrotate, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrotate, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
