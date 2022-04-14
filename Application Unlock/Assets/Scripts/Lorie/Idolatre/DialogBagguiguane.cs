using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogBagguiguane : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;

    void OnEnable()
    {
        index = 0;
        textDisplay.text = "";
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);

        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

    }
    IEnumerator TextChange()
    {
        {
            yield return new WaitForSeconds(0.2f);
        }
    }

    public void NextSentences()
    {
        continueButton.SetActive(false);
        StartCoroutine(TextChange());

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);

        }
    }
}
