using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenConfirmations : MonoBehaviour
{
    GameObject CloseConfirmation;
    GameObject HomeConfirmation;

    // Start is called before the first frame update
    void Start()
    {
        CloseConfirmation = GameObject.Find("QuitConfirmation");
        HomeConfirmation = GameObject.Find("HomeConfirmation");
        CloseConfirmation.SetActive(false);
        HomeConfirmation.SetActive(false);
    }

    public void OpenCloseConfirm()
    {
        if (HomeConfirmation)
        {
            HomeConfirmation.SetActive(false);
        }
        CloseConfirmation.SetActive(true);
    }

    public void CloseCloseConfirm()
    {
        CloseConfirmation.SetActive(false);
    }

    public void OpenHomeConfirm()
    {
        if (CloseConfirmation)
        {
            CloseConfirmation.SetActive(false);
        }
        HomeConfirmation.SetActive(true);
    }

    public void CloseHomeConfirm()
    {
        HomeConfirmation.SetActive(false);
    }
}
