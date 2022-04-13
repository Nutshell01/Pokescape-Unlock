using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SkillPokemon
{
    [SerializeField] private string NameOfSkill;
    [SerializeField] private Sprite IconeOfSkill;
    [SerializeField] private List<SuccessAndNextCards> ListOfSuccessAndNextCard = new List<SuccessAndNextCards>();
    [SerializeField] private bool IsEfficaceOnBoss;

    public string nameOfSkill => NameOfSkill;
    public Sprite iconeOfSkill => IconeOfSkill;

    public List<SuccessAndNextCards> listOfSuccessAndNextCard { get => ListOfSuccessAndNextCard; set => ListOfSuccessAndNextCard = value; }
    public bool isEfficaceOnBoss { get => IsEfficaceOnBoss;}
}

[Serializable]
public class SuccessAndNextCards
{
    [SerializeField] private int NbOfSucces;
    [SerializeField] private List<int> NbOfNextCard = new List<int>();

    public List<int> nbOfNextCard => NbOfNextCard;
    public int nbOfSucces => NbOfSucces;
}
