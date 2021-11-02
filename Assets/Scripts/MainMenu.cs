using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string playScene;
    public void Play()
    {
        SceneManager.LoadScene(playScene);
    }
    public void Settings()
    {
        Debug.Log("Opened settings.");
    }
    public void Quit()
    {
        Application.Quit();
    }
}