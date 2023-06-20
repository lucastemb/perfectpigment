using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Stopwatch : MonoBehaviour
{
    bool stopwatchActive = true;
    float currentTime;
    public Text currentTimeText;
    public Text finishText;

    void Start()
    {
        currentTime = 0;
    }
    
    void Update()
    {
        
        if (stopwatchActive == true) {
            currentTime = currentTime + Time.deltaTime;
        }    
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
        
    }

    public void StartStopwatch() {
        stopwatchActive = true;
    }

    public void StopStopwatch() {
        stopwatchActive = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
        finishText.text = "Final Time: " + currentTimeText.text;
        stopwatchActive = false;
        }
    }
}
