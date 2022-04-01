using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPokemon : MonoBehaviour
{
    public PokemonData pokemonData;

    private void Start()
    {
        GameObject.Instantiate(pokemonData.pokemonModel3D, Vector3.zero, pokemonData.pokemonModel3D.transform.rotation, transform);
    }

 
}
