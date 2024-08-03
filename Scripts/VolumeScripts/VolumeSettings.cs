using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSettings : MonoBehaviour
{
    GameObject VolumeSettingsMenu;

    // Start is called before the first frame update
    void Start()
    {
        VolumeSettingsMenu = GameObject.Find("VolumeSetting");
        VolumeSettingsMenu.SetActive(false);
    }

    public void Open()
    {
        VolumeSettingsMenu.SetActive(true);
    }

    public void Close()
    {
        VolumeSettingsMenu.SetActive(false);
    }
}
