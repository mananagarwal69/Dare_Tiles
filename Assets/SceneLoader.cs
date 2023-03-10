using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("You have quit the app");
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadBackScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
    }
}
