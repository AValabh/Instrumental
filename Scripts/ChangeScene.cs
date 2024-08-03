using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void toMusicPlayer()
    {
        SceneManager.LoadScene("Player", LoadSceneMode.Single);
    }

    public void toRecordings()
    {
        SceneManager.LoadScene("Recordings", LoadSceneMode.Single);
    }
}
