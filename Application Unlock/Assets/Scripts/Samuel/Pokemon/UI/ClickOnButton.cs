using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnButton : MonoBehaviour
{
    [SerializeField] private LogInterfacePokemon logInterfacePokemon;
    [SerializeField] private GameObject CanvasPokemonInterface;
    private void Awake()
    {
        UnityEngine.UI.Button b = gameObject.GetComponent<UnityEngine.UI.Button>();
        b.onClick.AddListener(OpenPokemonInterface);
    }
    public void OpenPokemonInterface()
    {
        Debug.Log(logInterfacePokemon.currentPokemon);
        CanvasPokemonInterface.GetComponent<Canvas>().enabled = true;
        CanvasPokemonInterface.GetComponent<SelectedPokemonCanvas>().ComputeCanvas(logInterfacePokemon.currentPokemon);
        
    }
}
