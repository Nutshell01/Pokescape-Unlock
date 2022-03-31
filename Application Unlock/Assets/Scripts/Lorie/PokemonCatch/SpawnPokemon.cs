using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPokemon : MonoBehaviour
{
    public PokemonScriptable pokemonScriptable;

    private void Update()
    {
        Debug.Log(pokemonScriptable.pokemon);
    }
}
