using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordingFullPromptRemove : MonoBehaviour
{
    public GameObject RecordingFullPrompt;
    // Start is called before the first frame update
    void Start()
    {
        RecordingFullPrompt = GameObject.Find("RecordingFullPrompt");
    }

    public void removePrompt()
    {
        RecordingFullPrompt.SetActive(false);
    }
}
