using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonDictionary : MonoBehaviour
{
    [SerializeField] PokemonScriptable[] _indiceObjectArray;
    public PokemonScriptable _defaultPokemon;
    public Dictionary<int, PokemonScriptable> _indices = new Dictionary<int, PokemonScriptable>();

    private void Awake()
    {
        foreach (PokemonScriptable value in _indiceObjectArray)
        {
            _indices.Add(value._pokemonNumber, value);
            Debug.Log(value);
        }
    }

    public PokemonScriptable GetIndiceValue(int index)
    {
        PokemonScriptable value;

        if (_indices.TryGetValue(index, out value))
        {
            return value;
        }
        else
        {

            return _defaultPokemon;
        }
    }
}
