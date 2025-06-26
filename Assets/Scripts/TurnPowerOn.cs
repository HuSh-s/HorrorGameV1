using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPowerOn : MonoBehaviour
{
    public GameObject[] lights;
    public GameObject text;

    public bool powerIsOn;
    private bool inReach;

    void Start()
    {
        foreach (GameObject ob in lights)
        {
            ob.SetActive(false);
        }

        text.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            inReach = true;
            text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            inReach = false;
            text.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact") && inReach)
        {
            powerIsOn = !powerIsOn;

            foreach (GameObject ob in lights)
            {
                ob.SetActive(powerIsOn);
            }

            text.SetActive(true);
        }

        if (inReach)
        {
            text.SetActive(true);
        }
    }
}
