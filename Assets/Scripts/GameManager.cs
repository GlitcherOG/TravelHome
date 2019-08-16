using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void NextScene()
    {
        // Get current scene
        Scene activeScene = SceneManager.GetActiveScene();
        // Load next scene
        SceneManager.LoadScene(activeScene.buildIndex + 1);
    }

    public void ReloadScene()
    {
        // Get current scene
        Scene activeScene = SceneManager.GetActiveScene();
        // Load next scene
        SceneManager.LoadScene(activeScene.buildIndex);
    }

    public void ExitGame()
    {
        //Stops playing the application if its in the editor and exits if its a built project
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying =
            false;
#endif 
        Application.Quit();
    }
}
