using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;
using System.IO;

public class Recorder : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float timeValue;
    public bool TimerOn = false;
    public string path;
    private StreamWriter writer;
    public GameObject RecorderActive;
    public GameObject RecorderInactive;
    public GameObject RecordingSavePrompt;
    public GameObject RecordingFullPrompt;
    string[] Recordings;
    public bool RecordingListFull;
    public string[] checkIfFull;
    public bool FileExists = false;

    // On record button press, start timer and recording.

    private void Start()
    {
        RecorderActive = GameObject.Find("RecordButtonImageOn");
        RecorderInactive = GameObject.Find("RecordButtonImageOff");
        RecordingSavePrompt = GameObject.Find("RecordingSavePrompt");
        RecordingFullPrompt = GameObject.Find("RecordingFullPrompt");
        RecorderInactive.SetActive(true);
        RecorderActive.SetActive(false);
        RecordingSavePrompt.SetActive(false);
        RecordingFullPrompt.SetActive(false);
    }
    public void OnRecord()
    {
        // Check if recordings are full.

            if (PlayerPrefs.GetString("Recording1") != "Empty" && PlayerPrefs.GetString("Recording2") != "Empty" && PlayerPrefs.GetString("Recording3") != "Empty" && PlayerPrefs.GetString("Recording4") != "Empty" && PlayerPrefs.GetString("Recording5") != "Empty" && PlayerPrefs.GetString("Recording6") != "Empty" && PlayerPrefs.GetString("Recording7") != "Empty" && PlayerPrefs.GetString("Recording8") != "Empty" && PlayerPrefs.GetString("Recording9") != "Empty")
            {
                RecordingListFull = true;
                // Display recordings Full and break function.
                RecordingFullPrompt.SetActive(true);
                return;
            }

    
        // Turns on Timer
        TimerOn = true;
        // swaps image
        RecorderActive.SetActive(true);
        RecorderInactive.SetActive(false);
        // Creates recording file
        //path = "Assets/Resources/Holder.txt";

        if (!File.Exists(Application.persistentDataPath + "/Holder.txt"))
        {
            File.Create(Application.persistentDataPath + "/Holder.txt").Dispose();
            path = Application.persistentDataPath + "/Holder.txt";
        }
        else { path = Application.persistentDataPath + "/Holder.txt"; }

        Debug.Log(Application.persistentDataPath);
        //Write some text to the test.txt file
        writer = new StreamWriter(path, true);
    }

    public void OffRecord()
    {
        TimerOn = false;
        // swaps image
        RecorderActive.SetActive(false);
        RecorderInactive.SetActive(true);
        // Open recording save prompt
        RecordingSavePrompt.SetActive(true);
        //close the writer
        writer.Close();

    }

    public void saveRecording()
    {
        string recordingName = GameObject.Find("RecordingName").GetComponent<TMP_InputField>().text;
        //Check for a open recording space and fill it if criteria is met
        for(int i = 1; i < 10; i++)
        {
            if(PlayerPrefs.GetString("Recording"+i) == "Empty" && recordingName != "")
            {
                Debug.Log("Saving to playerPreffs");
                PlayerPrefs.SetString("Recording" + i, recordingName);
                PlayerPrefs.Save();
                break;
            }
            else { Debug.Log("Recording list is full."); }
        }
        //Re-import the file to update the reference in the editor *If user wants to save, if not delete
        if(recordingName != "")
        {
            /*AssetDatabase.ImportAsset(path);
            AssetDatabase.RenameAsset(path, recordingName);
            AssetDatabase.Refresh();*/
            for(int i = 1; i <= 10; i++)
            {
                if((PlayerPrefs.GetString("Recording")+i) == recordingName)
                {
                    return;
                }
            }
            
            File.Move(path, Application.persistentDataPath + "/" + recordingName + ".txt");
            RecordingSavePrompt.SetActive(false);
        }
    }

    public void deleteRecording()
    {
        //AssetDatabase.DeleteAsset(path);
        //AssetDatabase.Refresh();
        RecordingSavePrompt.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        if(TimerOn == true)
        {
            timeValue += Time.fixedDeltaTime;
            UpdateTime(timeValue);
        }
        if(TimerOn == false)
        {
            timeValue = 0;
            timer.text = "0:00";
        }
    }

    void UpdateTime(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    // have buttons call function when tapped
    public void createRecord(float Time, string buttonName)
    {
        writer.WriteLine(Time);
        writer.WriteLine(buttonName);

    }
}
