using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MonoBehaviour
{
    GameObject HomeConfirmation;
    GameObject CloseConfirmation;

    // Start is called before the first frame update
    void Start()
    {
        HomeConfirmation = GameObject.Find("HomeConfirmation");
        CloseConfirmation = GameObject.Find("QuitConfirmation");
        HomeConfirmation.SetActive(false);
    }

    public void Open()
    {
        if (CloseConfirmation)
        {
            CloseConfirmation.SetActive(false);
        }
        HomeConfirmation.SetActive(true);
    }

    public void Close()
    {
        HomeConfirmation.SetActive(false);
    }
}
