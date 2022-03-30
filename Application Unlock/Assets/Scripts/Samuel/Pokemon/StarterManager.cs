using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterManager : MonoBehaviour
{
    [SerializeField] private PokemonData CurrentStarter;

    public PokemonData currentStarter { get => CurrentStarter; set => CurrentStarter = value; }

    public void AddTheStarter(PokemonData starter, PokemonData otherStarter, List<PokemonData> pokemonDatasList)
    {
        CurrentStarter = starter;
        pokemonDatasList.Remove(otherStarter);
    }
}
