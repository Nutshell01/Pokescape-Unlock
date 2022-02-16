using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedPokemonCanvas : MonoBehaviour
{
    private PokemonData CurrentPokemonData;
    [SerializeField] private LogInterfacePokemon MainLogInterfacePokemon;
    public void ComputeCanvas(PokemonData pokemonData)
    {
        CurrentPokemonData = pokemonData;
        MainLogInterfacePokemon.ComputeLogInterface(CurrentPokemonData.sprite, CurrentPokemonData.arrayTypeOfPokemons[0].typeIcone, CurrentPokemonData.arrayTypeOfPokemons[1].typeIcone, CurrentPokemonData.namePokemon, CurrentPokemonData);
        Debug.Log(CurrentPokemonData.namePokemon);
    }
}
