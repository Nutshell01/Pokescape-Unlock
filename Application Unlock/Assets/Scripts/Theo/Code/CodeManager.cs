using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeManager : MonoBehaviour
{
    [Space]
    [SerializeField] private Keypad keypadScript = null;

    [Space, Header("UI")]
    [SerializeField] private Canvas penalityCanvas = null;
    [SerializeField] private Canvas validatedCanvas = null;
    [SerializeField] private TextMeshProUGUI description = null;

    [Space, Header("Code & description")]
    [SerializeField] private List<int> codes = new List<int>(); //Liste de tout les codes valide
    [SerializeField, TextArea(3, 5)] private List<string> descCard = new List<string>(); //La description de la carte par rapport à l'indice du code

    private int codeToCheck = 0;

    private void Awake()
    {
        penalityCanvas.enabled = false;
        validatedCanvas.enabled = false;
    }

    public void CheckCode()
    {
        codeToCheck = keypadScript.GetOutputValue();

        if (!codes.Contains(codeToCheck)) //Si le code n'est pas dans la liste => invalide
        {
            Debug.Log("le code n'est dans la liste");
            DisplayPenalty();
        }
        else
        {
            for (int i = 0; i < codes.Count; i++) //on récupère l'indice de la liste des code pour pouvoir l'afficher dans DisplayCardUnlock()
            {
                if (codeToCheck == codes[i])
                {
                    Debug.Log("Le code : " + codes[i] + " débloque la carte XX");
                    DisplayCardUnlock(i);
                }
            }
        }
    }

    public void DisplayPenalty() //affiche un message quand on n'a pas rentrer le bon code
    {
        penalityCanvas.enabled = !penalityCanvas.enabled;
    }

    public void DisplayCardUnlock(int _index)
    {
        if(validatedCanvas.enabled)
        {
            validatedCanvas.enabled = !validatedCanvas.enabled; //désactive le canvas pour cacher l'UI
        }
        else //Sinon on active l'UI et on met à jour le text par rapport à l'index donné
        {
            validatedCanvas.enabled = true;

            description.text = descCard[_index];

        }
        
    }

}
