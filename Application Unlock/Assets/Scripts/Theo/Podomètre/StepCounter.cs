/* 
*   Pedometer
*   Copyright (c) 2018 Yusuf Olokoba
*/

namespace PedometerU.Tests {

    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;

    public class StepCounter : MonoBehaviour {

        public TextMeshProUGUI stepText; //distanceText si on veut une distance en ft
        public GameObject textOnWin, magicarpeImg, eggImg;
        private Pedometer pedometer;

        private void Start () 
        {
            // Create a new pedometer
            pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
            textOnWin.SetActive(false);
            magicarpeImg.SetActive(false);
            eggImg.SetActive(true);
        }

        private void OnStep (int steps, double distance) 
        {
            if(steps >= 100)
            {
                eggImg.SetActive(false);
                textOnWin.SetActive(true);
                magicarpeImg.SetActive(true);
                stepText.enabled = false;

                // éclosion du pokémon
                // End Mini Game

                return;
            }

            // Display the values // Distance in feet
            stepText.text = steps.ToString() + " / 100";
            //distanceText.text = (distance * 3.28084).ToString("F2") + " ft";
        }

        private void OnDisable () 
        {
            // Release the pedometer
            pedometer.Dispose();
            pedometer = null;
        }
    }
}