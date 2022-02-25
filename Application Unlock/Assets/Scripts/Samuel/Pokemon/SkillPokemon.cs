using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SkillPokemon
{
    [SerializeField] private string NameOfSkill;
    [SerializeField] private Sprite IconeOfSkill;

    public string nameOfSkill => NameOfSkill;
}
