﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Player : MonoBehaviour
{
    private AudioManager audioManager;

    [SerializeField]
    private AudioSource Land_Source;
    [SerializeField]
    private AudioSource Run_Source;
    [SerializeField]
    private AudioSource Jump_Source;
    [SerializeField]
    private AudioSource Dash_Source;

    void Awake()
    {
        audioManager = GameObject.FindWithTag("AudioManager").GetComponent<AudioManager>();
        audioManager.Player_Land += Land;
        audioManager.Player_Run += Run;
        audioManager.Player_Jump += Jump;
        audioManager.Player_Dash += Dash;
    }

    private void Land()
    {
        Land_Source.Play(0);
    }

    private void Jump()
    {
        Jump_Source.Play(0);
    }

    private void Run(bool isMoving)
    {
        if (isMoving && !Run_Source.isPlaying)
        {
            Run_Source.Play(0);
        }
        else if (isMoving && Run_Source.isPlaying)
        {
        }
        else
        {
            Run_Source.Stop();
        }
    }

    private void Dash()
    {
        Dash_Source.Play(0);
    }
}
