using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    //public float time;
    //public float TimerInterval = 5f;
    //public float tick;

    private void Start()
    {
        TimerCountDown();
    }
    private void Awake()
    {
        //time = (int)Time.time;
        //tick = TimerInterval;
    }

    private void Update()
    {
        //TimerCountDown();
        //TimerCountUp();


    }

    public void TimerCountUp()
    {
        /*GetComponent<TextMeshProUGUI>().text = string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);

        time = (int)Time.time;

        if (time == tick)
        {
            tick = time + TimerInterval;
        }*/
    }

    public void TimerCountDown()
    {

       
    }




}
