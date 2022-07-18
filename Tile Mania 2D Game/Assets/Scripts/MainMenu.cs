using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void ExistButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}
