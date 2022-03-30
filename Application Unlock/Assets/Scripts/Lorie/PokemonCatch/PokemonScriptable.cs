using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon")]

public class PokemonScriptable : ScriptableObject
{
    
    public int _pokemonNumber;
    public string Nom;
    public GameObject pokemon;
}

