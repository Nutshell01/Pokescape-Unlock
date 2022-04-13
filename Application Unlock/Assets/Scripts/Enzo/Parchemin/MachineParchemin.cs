using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MachineParchemin : MonoBehaviour
{
    [HideInInspector] public string _currentCombinaison;
    [HideInInspector] public string _currentGood;
    
      #region RéponseUI
    [SerializeField] GameObject _answerBox;
    [SerializeField] TextMeshProUGUI _answerText;
    [SerializeField] string _wrongText;
    [SerializeField] string _textToChange;
    #endregion
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
            _answerBox.SetActive(true);
            _answerText.text = _wrongText;
        }
        if (_count == 9)
        {
            if (_currentCombinaison == _currentGood)
            {
                _answerBox.SetActive(true);
                GetComponent<Canvas>().enabled = false;
                _answerText.text = _textToChange;
                // _count = -1;
            }

        }
    }
}
