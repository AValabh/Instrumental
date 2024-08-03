using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicalButtonVolume : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float globalVolume = GameObject.Find("Volume").GetComponent<GlobalVolume>().globalVolume;
        this.GetComponent<AudioSource>().volume = globalVolume;
    }
}
