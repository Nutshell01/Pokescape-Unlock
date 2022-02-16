using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pokedex : MonoBehaviour
{
    [SerializeField] private List<PokemonData> PokemonsInThePokedex = new List<PokemonData>();
    [SerializeField] private PokemonTeam pokemonTeam;

    private int test;
    private void ChangeBoolInTeam(PokemonData pokemon)
    {
        pokemon.isInTeam = true;
        pokemonTeam.pokemonsInTeam.Add(pokemon);
        pokemonTeam.ShowThePokemonInTeam(pokemon);
    }

    [ContextMenu("Test")]
    private void Test()
    {
        if (PokemonsInThePokedex[test] != null)
        {
            ChangeBoolInTeam(PokemonsInThePokedex[test]);

            test++;
        }
    }
}
