using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnIndice : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _currentIndiceNumber;
    [SerializeField] TextMeshProUGUI _currentText;
    [SerializeField] GameObject _IndiceButton;
    [SerializeField] GameObject _clavierCanvas;
    [SerializeField] Keypad _keycodeScript;
    [SerializeField] IndiceDictionary _dictionnaryScript;
    private int _indiceToSpawn;
    
    public void SpawnFirstIndice()
    {
        _indiceToSpawn = _keycodeScript.GetOutputValue();
        IndiceValue _valueToSpawn = _dictionnaryScript.GetIndiceValue(_indiceToSpawn);

        _currentIndiceNumber.text = "Indice n°" + _indiceToSpawn.ToString();

        _currentText.text = _valueToSpawn._firstIndice;

        _IndiceButton.SetActive(_valueToSpawn._usefulness);

       
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
