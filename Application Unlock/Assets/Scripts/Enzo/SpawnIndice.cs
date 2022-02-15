using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnIndice : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _currentIndiceNumber;
    [SerializeField] TextMeshProUGUI _currentText;
    
    [SerializeField] GameObject _clavierCanvas;
    [SerializeField] Keypad _keycodeScript;
    [SerializeField] IndiceDictionary _dictionnaryScript;
    private int _indiceToSpawn;
    
    public void SpawnFirstIndice()
    {
        _indiceToSpawn = _keycodeScript.GetOutputValue();
        _currentIndiceNumber.text = "Indice n°" + _dictionnaryScript.GetIndiceValue(_indiceToSpawn)._indiceNumber;
        _currentText.text = _dictionnaryScript.GetIndiceValue(_indiceToSpawn)._firstIndice;
       
    }
    public void SpawnSecondIndice()
    {
         _currentText.text = _dictionnaryScript.GetIndiceValue(_indiceToSpawn)._secondIndice;
    }

    public void ReactivateKeypad()
    {
        _clavierCanvas.SetActive(true);
    }
}
