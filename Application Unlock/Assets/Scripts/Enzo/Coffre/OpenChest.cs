using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;
public class OpenChest : MonoBehaviour
{

    [Space]
    [Header("Coffre Psytigri")]

    #region Psytigri
    [SerializeField] private TMP_InputField _inputChest;
    [SerializeField] bool _isPsytigri;
    [SerializeField] GameObject _clavierKey;
    [SerializeField] Sprite _chestOppened;
    [SerializeField] int _goodInput;
    [SerializeField] Button _buttonChest;
    [SerializeField] GameObject _buttonKey;
    #endregion

    [Space]
    [Header("Coffre Baggiguane")]

    #region Baggiguane

    [SerializeField] int _countToDestroy;
    [SerializeField] Sprite[] _chestDestroyedSprite;
    [SerializeField] Image _SpriteRenderer;
    private int _currentCount = 0;

    #endregion

    [Space]
    [Header("Réponse UI")]

    #region RéponseUI
    [SerializeField] GameObject _answerBox;
    [SerializeField] TextMeshProUGUI _answerText;
    [SerializeField] string _wrongText;
    [SerializeField] string _textPsytigri;
    [SerializeField] string _textBaggiguane;
    [SerializeField] GameObject _ContinueButton;

    #endregion

    [SerializeField] GameManager _gameManager;
    [SerializeField] StarterManager starterManager;

    void OnGUI()
    {
        _inputChest.text = Regex.Replace(_inputChest.text, @"[^0-9 ]", "");
    }
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        //check quel starter (a faire dans une fonction pour eviter de devoir le faire en boucle ??)

        if (starterManager.currentStarter.name == "Psytigri")
        {
            _isPsytigri = true;
        }
        else if (starterManager.currentStarter.name == "Bagguiguane")
        {
            _isPsytigri = false;
        }

        if (_isPsytigri == true)
        {
            _clavierKey.SetActive(true);
            _buttonChest.enabled = false;
            _buttonKey.SetActive(true);

        }
        else if (_isPsytigri == false)
        {
            _clavierKey.SetActive(false);
            _buttonChest.enabled = true;
            _buttonKey.SetActive(false);

        }

        if (_currentCount == _countToDestroy)
        {
            OpenWithHit();
            _currentCount = 0;

        }

        if (_currentCount > 3 && _currentCount < 5)
        {
            _SpriteRenderer.sprite = _chestDestroyedSprite[0];
        }
        if (_currentCount > 5 && _currentCount < 8)
        {
            _SpriteRenderer.sprite = _chestDestroyedSprite[1];
        }


    }

    public void HitChest() //compte le hit
    {
        _currentCount++;
    }

    public void OpenWithkey()
    {
        if (int.Parse(_inputChest.text) == _goodInput)
        {
            _answerText.text = _textPsytigri;
            _SpriteRenderer.sprite = _chestOppened;
            _clavierKey.SetActive(false);
            _buttonKey.SetActive(false);
            Open();
        }
        else
        {
            _answerText.text = _wrongText;
            _answerBox.SetActive(true);
        }
    }
    void OpenWithHit()
    {
        _answerText.text = _textBaggiguane;
        _SpriteRenderer.sprite = _chestDestroyedSprite[2];
        Open();
    }

    void Open()
    {
        _answerBox.SetActive(true);
        _ContinueButton.SetActive(true);
        _buttonChest.enabled = false;
    }



}
