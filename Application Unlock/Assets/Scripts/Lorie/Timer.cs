using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   public float TimerValue;

   public void TimerCountDown()
    {
        TimerValue = TimerValue - 0.01f * Time.deltaTime;
    }
    private void Update()
    {
        TimerCountDown();
    }
}
