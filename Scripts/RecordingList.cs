using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RecordingList : MonoBehaviour
{
    public bool hasPlayed;

    private void Start()
    {
        if (PlayerPrefs.HasKey("HasPlayed"))
        {
            hasPlayed = true;
        }
        else
        {
            PlayerPrefs.SetString("HasPlayed", "Yes");
            PlayerPrefs.SetString("Recording1", "Empty");
            PlayerPrefs.SetString("Recording2", "Empty");
            PlayerPrefs.SetString("Recording3", "Empty");
            PlayerPrefs.SetString("Recording4", "Empty");
            PlayerPrefs.SetString("Recording5", "Empty");
            PlayerPrefs.SetString("Recording6", "Empty");
            PlayerPrefs.SetString("Recording7", "Empty");
            PlayerPrefs.SetString("Recording8", "Empty");
            PlayerPrefs.SetString("Recording9", "Empty");
        }
    }
}
