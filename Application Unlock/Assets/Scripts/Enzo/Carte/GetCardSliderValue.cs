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
    [SerializeField] string _TextPsytigri;
    [SerializeField] string _TextBaggiguanne;
    [SerializeField] StarterManager starterManager = null;
    [SerializeField] GameObject _ContinueButton;

    private bool _isPsytigri;
    
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

        if(GetSliderValue(_longitudeSlider) == _valueLongitude && (GetSliderValue(_latitudeSlider) >= 50 && GetSliderValue(_latitudeSlider) <= 60)) //== _valueLatitude
        {

            if(_isPsytigri)
           _answerText.text = _TextPsytigri;
           else
           _answerText.text =  _TextBaggiguanne;
           _ContinueButton.SetActive(true);
        }
        else
        {
            _answerText.text = _wrongText;
            _ContinueButton.SetActive(false);
        }
    }
void GetStarter()
{
    
     if (starterManager.currentStarter.name == "Psytigri")
        {
           
            _isPsytigri = true;
        }

        else if (starterManager.currentStarter.name == "Bagguiguane")
        {
            _isPsytigri = false;

        }
}
    
}
