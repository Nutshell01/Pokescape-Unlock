using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeOfButton
{
    SelectedPokemon,
    SelectedSkill,
}
public class ClickOnButton : MonoBehaviour
{
    [SerializeField] private LogInterfacePokemon logInterfacePokemon;
    [SerializeField] private GameObject CanvasPokemonInterface;
    [SerializeField] private TypeOfButton CurrentTypeOfButton;
    private void Awake()
    {
        UnityEngine.UI.Button b = gameObject.GetComponent<UnityEngine.UI.Button>();
        if(CurrentTypeOfButton == TypeOfButton.SelectedPokemon)
        {
            b.onClick.AddListener(OpenPokemonInterface);
        }
        else if(CurrentTypeOfButton == TypeOfButton.SelectedSkill)
        {
        
        }
    }
    public void OpenPokemonInterface()
    {
        Debug.Log(logInterfacePokemon.currentPokemon);
        CanvasPokemonInterface.GetComponent<Canvas>().enabled = true;
        CanvasPokemonInterface.GetComponent<SelectedPokemonCanvas>().ComputeCanvas(logInterfacePokemon.currentPokemon);
    }

    public void OpenSkillInterface()
    {

    }
}
