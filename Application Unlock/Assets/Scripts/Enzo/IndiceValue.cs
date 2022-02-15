using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndiceValue 
{
    public string _indiceNumber;
    public string _firstIndice;
    public string _secondIndice;
    public bool _usefulness;
    
    public IndiceValue(string newIndiceNumber, string newFirstIndice, string newSecondIndice, bool isUseful)
    {
        _indiceNumber = newIndiceNumber;
        _firstIndice = newFirstIndice;
        _secondIndice = newSecondIndice;
        _usefulness = isUseful;
    }
   
}
