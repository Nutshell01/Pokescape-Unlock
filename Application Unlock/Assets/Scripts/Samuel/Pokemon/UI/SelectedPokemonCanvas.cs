using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectedPokemonCanvas : MonoBehaviour
{
    private PokemonData CurrentPokemonData;
    [SerializeField] private LogInterfacePokemon MainLogInterfacePokemon;
    [SerializeField] private TextMeshProUGUI[] CompetencesPokemonsName = new TextMeshProUGUI[4];
    [SerializeField] private SkillPokemonDataCanvas[] ArraySkillPokemonCanvas = new SkillPokemonDataCanvas[3];
    public void ComputeCanvas(PokemonData pokemonData)
    {
        CurrentPokemonData = pokemonData;
        MainLogInterfacePokemon.ComputeLogInterface(CurrentPokemonData.sprite, CurrentPokemonData.arrayTypeOfPokemons[0].typeIcone, CurrentPokemonData.arrayTypeOfPokemons[1].typeIcone, CurrentPokemonData.namePokemon, CurrentPokemonData);
        
        for(int i = 0; i<pokemonData.skillPokemons.Length; i++)
        {
            CompetencesPokemonsName[i].text = pokemonData.skillPokemons[i].nameOfSkill;
            ArraySkillPokemonCanvas[i].currentSkillPokemonCanvas = pokemonData.skillPokemons[i];
        }
    }
}
