using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayGame()
    {
        Invoke("PlayGameDelay",5);
    }
    public void Credits()
    {
        Invoke("CreditDelay", 5);
    }
    public void BackToMenu()
    {
        Invoke("BackToMenuDelay", 2);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void PlayGameDelay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void CreditDelay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void BackToMenuDelay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
