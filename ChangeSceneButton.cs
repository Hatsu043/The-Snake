using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    public void LoadScene(string sceneName)  //Change scene for play button
    {
        SceneManager.LoadScene(sceneName);
    }
}
