using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCardSliderValue : MonoBehaviour
{
    [SerializeField] Slider _longitudeSlider;
    [SerializeField] Slider _latitudeSlider;
    [SerializeField] int _valueLongitude;
    [SerializeField] int _valueLatitude;
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
        if(GetSliderValue(_longitudeSlider) == _valueLongitude && GetSliderValue(_latitudeSlider) == _valueLatitude)
        {
            Debug.Log("la tu fait un truc quoi");
        }
        else
        {
             Debug.Log("lqegifgueagbaezgae");
        }
    }
    
}
