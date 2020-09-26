using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public string sceneToLoad;

    public void playGame()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("Load Scene");
    }
    public void quitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
