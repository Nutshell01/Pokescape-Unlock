using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GetCardSliderValue : MonoBehaviour
{
    [SerializeField] Slider _longitudeSlider;
    [SerializeField] Slider _latitudeSlider;
    [SerializeField] int _valueLongitude;
    [SerializeField] int _valueLatitude;

    #region RéponseUI
    [SerializeField] GameObject _answerBox;
    [SerializeField] TextMeshProUGUI _answerText;
    [SerializeField] string _wrongText;
    [SerializeField] string _textToChange;
    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetSliderValue(_longitudeSlider) + " " + GetSliderValue(_latitudeSlider));
    }
    public int GetSliderValue(Slider slider)
    {
        return Mathf.RoundToInt(slider.value);
    }
    public void Activate()
    {
        _answerBox.SetActive(true);

        if(GetSliderValue(_longitudeSlider) == _valueLongitude && GetSliderValue(_latitudeSlider) == _valueLatitude)
        {
           _answerText.text = _textToChange;
        }
        else
        {
            _answerText.text = _wrongText;
        }
    }
    
}
