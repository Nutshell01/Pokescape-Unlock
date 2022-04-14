using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MachineManager : MonoBehaviour
{
    [Space]
    [SerializeField] private KeypadMachine keypadScript = null;
    [SerializeField] private Canvas errorMachine = null;
    
    [Space, Header("Codes & machines")]
    [SerializeField] private List<int> codesMachines = new List<int>(); //Liste de tout les codes pour appeler les machine
    [SerializeField] private List<GameObject> machines = new List<GameObject>(); //Les prefabs des machines

    private int codeToCheck = 0;

    private void Awake()
    {
        errorMachine.enabled = false;
    }

    public void CheckCode(int value)
    {
        codeToCheck = value;

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

    public void HideMachine(GameObject _machineCanvas)
    {
        _machineCanvas.SetActive(!_machineCanvas.activeSelf);
    }

    public void DisplayMachine(int _index)
    {
        machines[_index].SetActive(true);  
    }

}
