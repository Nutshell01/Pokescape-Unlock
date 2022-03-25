using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName ="PokemonData", menuName ="ScriptableObject/PokemonData")]
public class PokemonData : ScriptableObject
{
    [SerializeField] protected bool IsInTeam;

    public bool isInTeam { get { return IsInTeam; } set { IsInTeam = value; } }

    [SerializeField] protected string NamePokemon;

    [SerializeField] protected string InfoPokemon;

    [SerializeField] protected TypePokemon[] ArrayTypeOfPokemons = new TypePokemon[2];

    [SerializeField] protected Sprite IconPokemon;
    [SerializeField] protected int NumberOfPokemon;
    [SerializeField] protected SkillPokemon[] SkillPokemons = new SkillPokemon[3];
    [SerializeField] protected Dictionary<int, SkillPokemon> Oui = new Dictionary<int, SkillPokemon>();

    public int numberOfPokemon => NumberOfPokemon;
    public SkillPokemon[] skillPokemons { get { return SkillPokemons; } set { SkillPokemons = value; } }
    public TypePokemon[] arrayTypeOfPokemons => ArrayTypeOfPokemons;
    public string namePokemon => NamePokemon;
    public Sprite sprite { get { return IconPokemon; } set { IconPokemon = value; } }
}
