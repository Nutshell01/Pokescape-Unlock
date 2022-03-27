using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions; // needed for Regex
using System.Text;

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
        
        for(int i = 0; i < CurrentSkill.listOfSuccessAndNextCard.Count; i++)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (CurrentSkill.listOfSuccessAndNextCard[i].nbOfSucces == int.Parse(InputNumber.text))
            {
                SuccesCanvas.enabled = true;
                for(int j =0; j< CurrentSkill.listOfSuccessAndNextCard[i].nbOfNextCard.Count; j++)
                {
                    stringBuilder.Append(CurrentSkill.listOfSuccessAndNextCard[i].nbOfNextCard[j].ToString());
                    stringBuilder.Append(" ");
                }
                SuccesCanvasScript.ComputeNbOfCard(stringBuilder.ToString());
                return;
            }
        }
        PenalityCanvas.enabled = true;
    }
}
