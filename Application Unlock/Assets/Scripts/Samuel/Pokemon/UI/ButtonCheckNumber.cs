using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions; // needed for Regex

public class ButtonCheckNumber : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField InputNumber;
    [SerializeField] private Canvas SuccesCanvas;
    [SerializeField] private SuccesCanvas SuccesCanvasScript;
    [SerializeField] private Canvas PenalityCanvas;
    
    private SkillPokemon CurrentSkill;
    public SkillPokemon currentSkill { set { CurrentSkill = value; } get { return CurrentSkill; } }

    private void Awake()
    {
       Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(CheckNumber);
    }
    void OnGUI()
    {
        InputNumber.text = Regex.Replace(InputNumber.text, @"[^0-9 ]", "");
    }
    public void CheckNumber()
    {
        if (CurrentSkill.nbOfSucces == int.Parse(InputNumber.text))
        {
            SuccesCanvas.enabled = true;
            SuccesCanvasScript.ComputeNbOfCard(CurrentSkill.nbOfNextCard.ToString());
        }
        else
        {
            PenalityCanvas.enabled = true;
        }
    }
}
