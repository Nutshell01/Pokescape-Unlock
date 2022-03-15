using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    private string _input; //string a afficher sur l'écran
    private int _buttonPressed; //Compte le nombre de chiffre présent sur l'écran
    [SerializeField] int _cap; //Nombre de chiffre max dans le password
    [SerializeField] float _textSpacing4digits;
    [SerializeField] float _textSpacing2digits;
    [SerializeField] TextMeshProUGUI _screenText;
    [SerializeField] SpawnIndice _spawnIndice;
    [SerializeField] GameObject _clavierCanvas;
    private int _outputValue;


    private void Start()
    {
        _buttonPressed = 0;
        _input = "";
        _screenText.text = _input.ToString();
        if (_cap == 2)
        {
            _screenText.characterSpacing = _textSpacing2digits;
        }
        else if (_cap == 4)
        {
            _screenText.characterSpacing = _textSpacing4digits;
        }
    }

    private void Update()
    {
        if (_buttonPressed > _cap)
        {
            _buttonPressed = _cap;
        }

    }


    public void ValueEntered(string valueEntered) //gère ce que la touche renvoie
    {
        switch (valueEntered)
        {
            case "V":

                int.TryParse(_input, out _outputValue);
                _spawnIndice.SpawnFirstIndice();
                _input = "";
                _buttonPressed = 0;
                _screenText.text = _input.ToString();
                _clavierCanvas.SetActive(false);

                break;

            case "C":
                _input = "";
                _buttonPressed = 0;
                _screenText.text = _input.ToString();
                break;

            default:
                if (_buttonPressed < _cap)
                {
                    _buttonPressed++;
                    _input += valueEntered;
                    _screenText.text = _input.ToString();

                }
                break;

        }
    }
    public int GetOutputValue()
    {

        return _outputValue;
    }

}