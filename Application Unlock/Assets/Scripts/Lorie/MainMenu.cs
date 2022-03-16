using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TimerCountDown timerCountDown = null;
 

    [Header("Buttons")]

    public Button Play;
    public Button Mistake;
    public Button Indice;
    public Button Machine;
    public Button Pokedex;
    public Button RevoirIndice;
    public Button Team;

    public bool Pause = false;


    public void StartGame()
    {
        if(Pause == true)
        {
            Mistake.enabled = true;
            Indice.enabled = true;
            Machine.enabled = true;
            Pokedex.enabled = true;
            RevoirIndice.enabled = true;
            Team.enabled = true;
            timerCountDown.enabled = true;

            Pause = false;
        }

        else if(Pause == false)
        {
            Mistake.enabled = false;
            Indice.enabled = false;
            Machine.enabled = false;
            Pokedex.enabled = false;
            RevoirIndice.enabled = false;
            Team.enabled = false;

            
            Pause = true;
        }
    }
 

    public void OnMistakeClick()
    {

    }

    
}
