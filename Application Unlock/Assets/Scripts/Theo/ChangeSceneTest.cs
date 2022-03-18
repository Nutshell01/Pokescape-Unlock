using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTest : MonoBehaviour
{
    public void ChangeScene(string _sceneName)
    {
        Debug.Log("Loding scene " + _sceneName);
        SceneManager.LoadSceneAsync(_sceneName);
    }
}
