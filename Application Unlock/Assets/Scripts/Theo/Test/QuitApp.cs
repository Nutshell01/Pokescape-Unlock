using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public void ExitApplication()
    {
        Debug.Log("Arret de l'application");
        Application.Quit();
    }
}
