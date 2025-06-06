﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject menu;
    public GameObject resume;
    public GameObject quit;

    public bool on;
    public bool off;

    void Start()
    {
        menu.SetActive(false);
        off = true;
        on = false;
    }

    void Update()
    {
        if (off && Input.GetButtonDown("pause"))
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            off = false;
            on = true;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }

        else if (on && Input.GetButtonDown("pause"))
        {
            Time.timeScale = 1;
            menu.SetActive(false);
            off = true;
            on = false;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void Resume()
    {
        menu.SetActive(false);
        off = true;
        on = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
