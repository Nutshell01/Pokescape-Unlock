using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeManager : MonoBehaviour
{
    [Space]
    [SerializeField] private Keypad keypadScript = null;
    [SerializeField] private Canvas errorMachine = null;
    
    [Space, Header("Codes & machines")]
    [SerializeField] private List<int> codesMachines = new List<int>(); //Liste de tout les codes pour appeler les machine
    [SerializeField] private List<Canvas> machines = new List<Canvas>(); //Les prefabs des machines

    private int codeToCheck = 0;

    private void Awake()
    {
        errorMachine.enabled = false;
    }

    public void CheckCode()
    {
        codeToCheck = keypadScript.GetOutputValue();

        if (!codesMachines.Contains(codeToCheck)) //Si le code n'est pas dans la liste => invalide
        {
            Debug.Log("La machine n'existe pas");
            DisplayError();
        }
        else
        {
            for (int i = 0; i < codesMachines.Count; i++)
            {
                if (codeToCheck == codesMachines[i])
                {
                    DisplayMachine(i);
                }
            }
        }
    }

    public void DisplayError() //affiche un message d'erreur quand la machine n'existe pas
    {
        errorMachine.enabled = !errorMachine.enabled;
    }

    public void DisplayMachine(int _index)
    {
        machines[_index].enabled = true;  
    }

}
