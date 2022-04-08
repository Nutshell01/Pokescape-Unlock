using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineParchemin : MonoBehaviour
{
    [HideInInspector] public string _currentCombinaison;
    [HideInInspector] public string _currentGood;
    
    public int _count = -1;
    [HideInInspector]
    public enum Possibilities
    {

        Blue = 1,
        Red = 2,
        Green = 3,
    }

    [SerializeField] public Possibilities[] _combinaison;
    void Update()
    {
        Debug.Log("good = " + _currentGood);
        Debug.Log("current = " + _currentCombinaison);

        if (_currentCombinaison != _currentGood && _count > -1)
        {


            _count = -1;
            _currentGood = "";
            _currentCombinaison = "";
        }
        if (_count == 9)
        {
            if (_currentCombinaison == _currentGood)
            {
                Debug.Log("good");
                // _count = -1;
            }

        }
    }
}
