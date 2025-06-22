using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitch : MonoBehaviour
{
   // public GameObject object00;
    public GameObject object01;
    public GameObject object02;
    public GameObject object03;
    public GameObject object04;



    void Start()
    {
       // object00.SetActive(false);
        object01.SetActive(false);
        object02.SetActive(false);
        object03.SetActive(false);
        object04.SetActive(false);
    }




    void Update()
    {
        if(Input.GetButtonDown("1"))
        {
           // object00.SetActive(true);
            object01.SetActive(false);
            object02.SetActive(false);
            object03.SetActive(false);
            object04.SetActive(false);
        }

        if (Input.GetButtonDown("2"))
        {
           // object00.SetActive(false);
            object01.SetActive(true);
            object02.SetActive(false);
            object03.SetActive(false);
            object04.SetActive(false);
        }

        if (Input.GetButtonDown("3"))
        {
           // object00.SetActive(false);
            object01.SetActive(false);
            object02.SetActive(true);
            object03.SetActive(false);
            object04.SetActive(false);
        }

        if (Input.GetButtonDown("4"))
        {
           // object00.SetActive(false);
            object01.SetActive(false);
            object02.SetActive(false);
            object03.SetActive(true);
            object04.SetActive(false);
        }

        if (Input.GetButtonDown("5"))
        {
            // object00.SetActive(false);
            object01.SetActive(false);
            object02.SetActive(false);
            object03.SetActive(false);
            object04.SetActive(true);
        }


    }
}
