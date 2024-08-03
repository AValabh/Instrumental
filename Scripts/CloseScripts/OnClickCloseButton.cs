using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickCloseButton : MonoBehaviour
{
    GameObject CloseConfirmation;
    GameObject HomeConfirmation;

    // Start is called before the first frame update
    void Start()
    {
        CloseConfirmation = GameObject.Find("QuitConfirmation");
        HomeConfirmation = GameObject.Find("HomeConfirmation");
        CloseConfirmation.SetActive(false);
    }

    public void Open()
    {
        if (HomeConfirmation)
        {
            HomeConfirmation.SetActive(false);
        }
        CloseConfirmation.SetActive(true);
    }

    public void Close()
    {
        CloseConfirmation.SetActive(false);
    }
}
