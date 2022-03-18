using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pokedex : MonoBehaviour
{
    [SerializeField] private List<PokemonData> PokemonsInThePokedex = new List<PokemonData>();
    public List<PokemonData> pokemonInThePokedex => PokemonsInThePokedex;
    [SerializeField] private PokemonTeam pokemonTeam;

    private void Awake()
    {
        for(int i = 0; i<PokemonsInThePokedex.Count; i++)
        {
            PokemonsInThePokedex[i].isInTeam = false;
        }
    }
    private void ChangeBoolInTeam(PokemonData pokemon)
    {
        pokemon.isInTeam = true;
        pokemonTeam.pokemonsInTeam.Add(pokemon);
        pokemonTeam.ShowThePokemonInTeam(pokemon);
    }
}
