using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LampeSale : MonoBehaviour
{
    [SerializeField] float _cleanness = 100;
    [SerializeField] float _cleaningCoefficiency;
    [SerializeField] Button _lampButton;
    private bool _isClean;

     #region RéponseUI
    [SerializeField] GameObject _answerBox;
    [SerializeField] TextMeshProUGUI _answerText;
    [SerializeField] string _wrongText;
    [SerializeField] string _textToChange;
    
    #endregion
   
    void Update()
    {    
         
        if(_cleanness <= 0)
        {
            Victory();
            _cleanness = 100;
        }

    }

    public void OnMouseDrag()
    {
        _cleanness -= _cleaningCoefficiency * Time.deltaTime;
    }
    public void Victory()
    {
        _lampButton.enabled = false;
        _answerBox.SetActive(false);
        _answerText.text = _textToChange;
        
    }
}
