using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogChoice : MonoBehaviour
{
    public GameObject Psytigri;
    public GameObject Bagguiguane;
    [SerializeField] private StarterManager starterManager = null;
  
    public void CheckStarter()
    {
        if (starterManager.currentStarter.name == "Psytigri")
        {
            Psytigri.SetActive(true);

        }

        else if (starterManager.currentStarter.name == "Bagguiguane")
        {
            Bagguiguane.SetActive(true);

        }
    }
}
