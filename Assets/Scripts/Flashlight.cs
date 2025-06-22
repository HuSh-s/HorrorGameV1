using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;
    //public GameObject flashlightModel;

    public AudioSource turnOn;
    public AudioSource turnOff;

    public bool Ison;

    void Start()
    {
        Ison = false;
        flashlight.SetActive(false);
    }




    void Update()
    {
        // if (flashlightModel.activeInHierarchy == true)
        
            if (Ison == false && Input.GetButtonDown("F"))
            {
                flashlight.SetActive(true);
                turnOn.Play();
                Ison = true;
            }
            else if (Ison == true && Input.GetButtonDown("F"))
            {
                flashlight.SetActive(false);
                turnOff.Play();
                Ison = false;
            }
        
       /* else if (flashlightModel.activeInHierarchy == false)
        {
            flashlight.SetActive(false);
            off = true;
            on = false;
        }
        
            */


    }
}
