using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
