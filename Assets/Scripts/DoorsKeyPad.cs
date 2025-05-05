using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorsKeyPad : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    public AudioSource doorSound;
    public bool DoorIsOpen;

    public bool inReach;




    void Start()
    {
        inReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }





    void Update()
    {
        
        if (DoorIsOpen == true && inReach && Input.GetButtonDown("Interact"))
        {
            DoorCloses();
        }
    }
    public void DoorOpens()
    {
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        doorSound.Play();
        DoorIsOpen = true;

    }

    public void DoorCloses()
    {
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
        DoorIsOpen = false;
    }
    
}