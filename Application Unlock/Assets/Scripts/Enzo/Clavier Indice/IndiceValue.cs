using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Indice", menuName = "Indice")]

public class IndiceValue : ScriptableObject
{
    public int _indiceNumber;
    [TextArea(3, 5)]public string _firstIndice;
     [TextArea(3, 5)]public string _secondIndice;
    public bool _usefulness;
    
    // public IndiceValue(string newIndiceNumber, string newFirstIndice, string newSecondIndice, bool isUseful)
    // {
    //     _indiceNumber = newIndiceNumber;
    //     _firstIndice = newFirstIndice;
    //     _secondIndice = newSecondIndice;
    //     _usefulness = isUseful;
    // }
   
}
