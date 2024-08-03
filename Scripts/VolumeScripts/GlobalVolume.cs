using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVolume : MonoBehaviour
{
    public float globalVolume;
    GameObject VolumeControl;
    GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        globalVolume = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("VolumeSetting"))
        {
            slider = GameObject.Find("VolumeSlider");
            globalVolume = slider.GetComponent<Slider>().value;
        }
    }
}
