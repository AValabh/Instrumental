using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayRecording : MonoBehaviour
{
    public string SongName;
    public bool StopReading;
    public string TimerTime;
    string[] readLines;
    public string path;
    public StreamReader reader;
    public int buttonsPressed;
    public int ButtonNumber = 0;
    public int CurrentButton = 0;
    public GameObject ButtonToPress;
    public bool PlayRecord;
    public GameObject Clock;
    public GameObject RecordingSelector;
    public bool textIsRead = false;
    // Start is called before the first frame update
    void Start()
    {
        RecordingSelector = GameObject.Find("RecordingSelector");
        StopReading = false;


        Clock = GameObject.Find("Timer");
        PlayRecord = false;
    }

    // Update is called once per frame
    void ReadText()
    {
        //path = "Assets/Resources/" + SongName + ".txt";
        path = Application.persistentDataPath + "/" + SongName + ".txt";
        reader = new StreamReader(path);
        readLines = File.ReadAllLines(path);
        buttonsPressed = (readLines.Length) / 2;
    }

    void FixedUpdate()
    {
        TimerTime = Clock.gameObject.GetComponent<Timer>().timeValue.ToString();
        if (PlayRecord && SongName != "")
        {
            if (textIsRead == false)
            {
                ReadText();
                Clock.gameObject.GetComponent<Timer>().TimerStart = true;
                textIsRead = true;
            }

            if (float.Parse(readLines[CurrentButton]) <= float.Parse(TimerTime))
            {
                Debug.Log("Time matched");
                //if time and read time match Play sound and effect.
                ButtonToPress = GameObject.Find(readLines[(CurrentButton + 1)]);
                //Instantiate effect and play sound
                ButtonToPress.GetComponent<OnClickSoundButton>().PlayEffect();
                ButtonToPress.GetComponent<OnClickSoundButton>().PlaySound();
                ButtonNumber++;
                CurrentButton += 2;
                if(ButtonNumber >= (buttonsPressed))
                {
                    reader.Close();
                    PlayRecord = false;
                    RecordingSelector.SetActive(true);
                    textIsRead = false;
                    SongName = "";
                    Clock.gameObject.GetComponent<Timer>().TimerStart = false;
                    ButtonNumber = 0;
                    CurrentButton = 0;
                }
            }
        }
        if(PlayRecord == false)
        {

        }
    }
}
