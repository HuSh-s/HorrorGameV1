using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    float currentTime;
    public TextMeshProUGUI currentTimeText;


    void Start()
    {
        currentTime = 0;
    }


    void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
        
    }
}
