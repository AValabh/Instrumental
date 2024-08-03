using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonRecorder : MonoBehaviour
{
    public Recorder recording;
    public TextMeshProUGUI timer;

    private void Start()
    {
        timer = GameObject.Find("time").GetComponent<TextMeshProUGUI>();
    }
    public void OnClick()
    {
        // if recording is on print to file
        if(recording.TimerOn == true)
        {
            recording.createRecord(recording.timeValue, EventSystem.current.currentSelectedGameObject.name);
        }
    }
}
