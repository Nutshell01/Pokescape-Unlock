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
    [SerializeField] private LogInterfacePokemon logInterfacePokemon = null;
    [SerializeField] private SkillPokemonDataCanvas skillPokemonDataCanvas;
    [SerializeField] private GameObject CanvasInterface = null;
    [SerializeField] private TypeOfButton CurrentTypeOfButton = TypeOfButton.SelectedPokemon;
    private void Awake()
    {
        UnityEngine.UI.Button b = gameObject.GetComponent<UnityEngine.UI.Button>();
        if(CurrentTypeOfButton == TypeOfButton.SelectedPokemon)
        {
            b.onClick.AddListener(OpenPokemonInterface);
        }
        else if(CurrentTypeOfButton == TypeOfButton.SelectedSkill)
        {
            b.onClick.AddListener(OpenSkillInterface);

        }
    }
    public void OpenPokemonInterface()
    {
        CanvasInterface.GetComponent<Canvas>().enabled = true;
        CanvasInterface.GetComponent<SelectedPokemonCanvas>().ComputeCanvas(logInterfacePokemon.currentPokemon);
    }

    public void OpenSkillInterface()
    {
        CanvasInterface.GetComponent<SelectedSkillsCanvas>().ComputeCanvas(skillPokemonDataCanvas.currentSkillPokemonCanvas);
        CanvasInterface.GetComponent<Canvas>().enabled = true;
    }
}
