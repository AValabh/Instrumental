using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class RecordSelector : MonoBehaviour
{
    public GameObject PlayRecord;
    public GameObject RecordingSelector;
    public GameObject[] Recordings;
    public string path;
    public string SongName;

    // Start is called before the first frame update
    void Start()
    {
        RecordingSelector = GameObject.Find("RecordingSelector");
        //PlayRecord.SetActive(false);
        for(int i = 0; i < 9; i++)
        {
            Recordings[i].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = PlayerPrefs.GetString("Recording" + (i + 1));
        }
    }

    public void PlayRecording(int recordingNumber)
    {
        if(Recordings[recordingNumber].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text != "Empty")
        {
            PlayRecord.GetComponent<PlayRecording>().SongName = Recordings[recordingNumber].transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text;
            PlayRecord.GetComponent<PlayRecording>().PlayRecord = true;
            RecordingSelector.SetActive(false);
            //PlayRecord.SetActive(true);
        }
    }
    public void DeleteRecording(int recordingNumber)
    {
        Debug.Log("Delete is called");
        if (PlayerPrefs.GetString("Recording"+recordingNumber) != "Empty")
        {
            Debug.Log("Delete has started");
            // Gets Song name and path of file
            SongName = PlayerPrefs.GetString("Recording" + recordingNumber);
            Debug.Log(SongName);
            path = Application.persistentDataPath + "/" + SongName + ".txt";
            Debug.Log(path);
            // Deletes the file
            File.Delete(path);
            //UnityEditor.AssetDatabase.Refresh();
            // Sets the pref to empty
            PlayerPrefs.SetString("Recording" + recordingNumber, "Empty");
            PlayerPrefs.Save();
            // Sets Text to resemble change
            GameObject.Find("Recording" + (recordingNumber)).transform.GetChild(0).GetComponent<TMP_Text>().text = "Empty";
            // remove the conformation for delete.
            //GameObject.Find("Recording" + recordingNumber).transform.GetChild(3).GetComponent<Removerecordings>().RemoveConformation();
        }
    }
}
