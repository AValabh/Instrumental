using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float timeValue;
    public bool TimerStart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimerStart == true)
        {
            timeValue += Time.deltaTime;
            UpdateTime(timeValue);
        }
        if (TimerStart == false)
        {
            timeValue = 0f;
            UpdateTime(timeValue);
        }

    }

    void UpdateTime(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
