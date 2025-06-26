using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUIZoom : MonoBehaviour
{

    public Animator camAnimator;
    public GameObject CamCanvas;
    private bool isZoomedIn = false;
    public GameObject Inventory;
    public GameObject HUD;
    private bool camactive;


    private void Start()
    {
        CamCanvas.SetActive(false);
        camactive = false;
    }

    void Update()
    {
        if (!camactive)
        {
            if (Input.GetButtonDown("MiddleMouse"))
            {

                CamCanvas.SetActive(true);
                Inventory.SetActive(false);
                HUD.SetActive(false);
                camactive= true;
            }
        }
        else
        {
            if (Input.GetButtonDown("MiddleMouse"))
            {

                CamCanvas.SetActive(false);
                Inventory.SetActive(true);
                HUD.SetActive(true);
                camactive= false;
            }
            if (Input.GetButtonDown("ZoomButton"))
            {
                if (!isZoomedIn)
                {
                    camAnimator.SetBool("Zoom", true);
                    camAnimator.SetBool("Idle", false);
                    isZoomedIn = true;
                }

                else
                {

                    camAnimator.SetBool("Zoom", false);
                    camAnimator.SetBool("Idle", false);
                    isZoomedIn = false;
                }
            }
        }
    }
}

