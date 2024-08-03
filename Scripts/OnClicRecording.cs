using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClicRecording : MonoBehaviour
{
    public GameObject RecordSelect;
    public int RecordingNumber;
    private void Start()
    {
        RecordSelect = GameObject.Find("RecordSelector");
    }
    public void OnClick()
    {
        RecordSelect.GetComponent<RecordSelector>().PlayRecording(RecordingNumber);
    }
}
