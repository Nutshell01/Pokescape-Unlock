using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluteButton : MonoBehaviour
{
    [SerializeField] MachineParchemin _parcheminScript;
    enum ColorButton
    {
        Blue = 1,
        Red = 2,
        Green = 3,
    }

    private ColorButton _buttonColor;
    [SerializeField] ColorButton _outputColor;
    public int Outputvalue()
    {
        Debug.Log(_outputColor);
        return ((int)_outputColor);
    }
    public void Output()
    {
        _parcheminScript._count ++;
        _parcheminScript._currentCombinaison += Outputvalue().ToString();
        _parcheminScript._currentGood += ((int)_parcheminScript._combinaison[_parcheminScript._count]).ToString();
    }

    
}
