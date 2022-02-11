using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pokedex : MonoBehaviour
{
    [SerializeField] private List<Pokemon> PokemonsInThePokedex = new List<Pokemon>();
    [SerializeField] private PokemonTeam pokemonTeam;

    private int test;
    private void ChangeBoolInTeam(Pokemon pokemon)
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
