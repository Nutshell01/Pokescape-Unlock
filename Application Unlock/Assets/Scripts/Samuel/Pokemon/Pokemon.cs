using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum TypeOfPokemon
{
    Fire,
    Normal,
    Poison,
    Psychic,
    Grass,
    Ground,
    Ice,
    Rock,
    Dragon,
    Water,
    Bug,
    Dark,
    Fighting,
    Ghost,
    Steel,
    Flying,
    Electric,
    Fairy
}

[Serializable]
public class Pokemon
{
    [SerializeField] protected bool IsInTeam;

    public bool isInTeam { get { return IsInTeam; } set { IsInTeam = value; } }

    [SerializeField] protected string NamePokemon;

    [SerializeField] protected string InfoPokemon;

    [SerializeField] protected TypeOfPokemon[] ArrayTypeOfPokemons = new TypeOfPokemon[2];

    [SerializeField] protected Sprite IconPokemon;

    public Sprite sprite { get { return IconPokemon; } set { IconPokemon = value; } }
}
