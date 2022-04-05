using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPokemon : MonoBehaviour
{
    public PokemonData pokemonData;
    private Vector3 toto = new Vector3(0,-0.7f,4);

    private void Start()
    {
       GameObject.Instantiate(pokemonData.pokemonModel3D, toto, pokemonData.pokemonModel3D.transform.rotation);
    }

 
}
