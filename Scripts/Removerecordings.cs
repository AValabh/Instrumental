using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removerecordings : MonoBehaviour
{
    // if in delete recording
    // select recording to delete, confirm delete
    // delete file and reset player pref to Empty
    // Reset text to empty to show change
    public GameObject DeleteConformation; 
    public GameObject RecordSelect;
    public int RecordingNumber;
    private void Start()
    {
        DeleteConformation = this.gameObject.transform.GetChild(0).gameObject;
        DeleteConformation.SetActive(false);
        RecordSelect = GameObject.Find("RecordSelector");
    }
    public void OnClick()
    {
        DeleteConformation.SetActive(true);
    }
    public void RemoveConformation()
    {
        DeleteConformation.SetActive(false);
    }
    public void DeleteRecording()
    {
        RecordSelect.GetComponent<RecordSelector>().DeleteRecording(RecordingNumber);
        DeleteConformation.SetActive(false);
    }
}
