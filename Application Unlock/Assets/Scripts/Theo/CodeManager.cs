using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeManager : MonoBehaviour
{
    [SerializeField] private Keypad keypadScript = null;
    [SerializeField] private List<int> codes = new List<int>();
    private int codeToCheck = 0;


    public void CheckCode()
    {
        codeToCheck = keypadScript.GetOutputValue();

        if (codeToCheck == codes[0])
        {
            Debug.Log("code 1234");
        }
        else if (codeToCheck == codes[1])
        {
            Debug.Log("code 4826");
        }
        else if (codeToCheck == codes[2])
        {
            Debug.Log("code 7845");
        }
        else if (codeToCheck == codes[3])
        {
            Debug.Log("code 1793");
        }


    }

}
