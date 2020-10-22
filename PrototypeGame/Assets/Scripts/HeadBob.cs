﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBob : MonoBehaviour
{
    public CharacterController controller;
    public Animation headbob;
    private bool moving;
    private bool left;
    private bool right;

    // Start is called before the first frame update
    void Start()
    {
        left = true;
        right = false;
    }

    void CameraAnimation()
    {
        if (controller.isGrounded == true)
        {
            if (moving == true)
            {
                if (left == true)
                {
                    if (!headbob.isPlaying)
                    {
                        headbob.Play("walkLeft");
                        left = false;
                        right = true;
                    }
                }

                if (right == true)
                {
                    if (!headbob.isPlaying)
                    {
                        headbob.Play("walkRight");
                        right = false;
                        left = true;
                    }
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0 || y !=0)
        {
            moving = true;
        }
        else if (x == 0 || y == 0)
        {
            moving = false;
        }
        CameraAnimation();
    }
}