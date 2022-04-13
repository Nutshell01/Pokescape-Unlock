using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MiaoussMachine : MonoBehaviour
{
    [SerializeField] MiaoussButton[] _buttons;

      #region RéponseUI
    [SerializeField] GameObject _answerBox;
    [SerializeField] TextMeshProUGUI _answerText;
    [SerializeField] string _wrongText;
    [SerializeField] string _textToChange;
    
    #endregion
  

    public void Check()
    {
        bool AllTrue = true;
        for (int i = 0; i < _buttons.Length; i++)
        {
            if (_buttons[i]._isGood == false)
            {
                AllTrue = false;
                break;
            }

        }
          _answerBox.SetActive(true);
        if (AllTrue)
        {
            _answerText.text = _textToChange;
        }
        else
        {
             _answerText.text = _wrongText;
        }
    }
}
