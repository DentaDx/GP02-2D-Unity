using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Buat make UI
using TMPro;    // Buat UI + Text Mesh Pro

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float startTime;
    public float timerDuration = 20f;
        
    void Start()
    {
        startTime = Time.time;
        StartCoroutine(UpdateTimer());
    }

    IEnumerator UpdateTimer()
    {
        while (true)
        {
            float timePassed = Time.time - startTime;
            float timeRemaining = timerDuration - timePassed;

            if(timeRemaining <= 0f)
            {
                timerText.text = "00:00";
                break;
            }

            string minutes = Mathf.Floor(timePassed / 60).ToString("00");
            string seconds = (timePassed % 60).ToString("00");
            timerText.text = minutes + ":" + seconds;
            yield return null;
        }
    }

}
