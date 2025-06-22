using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActive : MonoBehaviour
{
    public GameObject Cam;
    public bool Ison;

    void Start()
    {
        Ison = false;
        Cam.SetActive(false);
    }
    void Update()
    {
        if (!Ison && Input.GetButtonDown("C"))
        {
            Cam.SetActive(true);
            Ison = true;
        }
        else if (Ison && Input.GetButtonDown("C"))
        {
            Cam.SetActive(false);
            Ison = false;
        }
    }
}
