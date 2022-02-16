using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Timer timer = null;

    [Header("Button")]

    public Button Play;
    public Button Mistake;
    public Button Indice;
    public Button Machine;
    public Button Pokedex;
    public Button RevoirIndice;
    public Button Team;

    public void StartGame()
    {
        Mistake.enabled = true;
        Indice.enabled = true;
        Machine.enabled = true;
        Pokedex.enabled = true;
        RevoirIndice.enabled = true;
        Team.enabled = true;

        timer.TimerCountDown();
    }
    
    public void OnMistakeClick()
    {

    }

    
}
