using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogChoice : MonoBehaviour
{
    public GameObject Psytigri;
    public GameObject Bagguiguane;
    [SerializeField] private StarterManager starterManager = null;
    private void Update()
    {
        if (starterManager.currentStarter.name == "Daltonien")
        {
            Psytigri.SetActive(true);

        }

        else if (starterManager.currentStarter.name == "Flambi")
        {
            Bagguiguane.SetActive(true);

        }
    }
}
