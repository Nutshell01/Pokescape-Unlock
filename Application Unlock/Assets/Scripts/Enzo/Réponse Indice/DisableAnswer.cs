using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAnswer : MonoBehaviour
{
    [HideInInspector] public GameObject _CurrentMachine;
    [SerializeField] Canvas _keypadCanvas;
   
    public void Disable()
    {
        gameObject.SetActive(false);
    }
     public void GoToMain()
    {
        _keypadCanvas.enabled = false;
        gameObject.SetActive(false);
        _CurrentMachine.SetActive(false);
        
        
    }

}
