using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnIndice : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _currentIndiceNumber;
    [SerializeField] TextMeshProUGUI _currentFirstText;
    [SerializeField] TextMeshProUGUI _currentSecondText;

    [SerializeField] Keypad _keycodeScript;
    [SerializeField] IndiceDictionary _dictionnaryScript;
    private int _indiceToSpawn;
    
    public void ChangeIndice()
    {
        _indiceToSpawn = _keycodeScript.GetOutputValue();
        _currentIndiceNumber.text = _dictionnaryScript.GetIndiceValue(_indiceToSpawn)._indiceNumber;
        _currentFirstText.text = _dictionnaryScript.GetIndiceValue(_indiceToSpawn)._firstIndice;
        _currentSecondText.text = _dictionnaryScript.GetIndiceValue(_indiceToSpawn)._secondIndice;
    }
}
