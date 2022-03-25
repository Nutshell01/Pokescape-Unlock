using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenChest : MonoBehaviour
{
    #region Psytigri
    [SerializeField] bool _isPsytigri;
    [SerializeField] GameObject _clavierKey;
    [SerializeField] int _goodInput;
    [SerializeField] Button _button;
    #endregion

    #region Baggiguane

    private int _countToDestroy = 10;
    [SerializeField] Sprite[] _chestSprite;
    [SerializeField] Image _SpriteRenderer;

    #endregion

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check quel starter
        if (_isPsytigri)
        {
            _clavierKey.SetActive(true);
            _button.enabled = false;
        }
        else
        {
            _clavierKey.SetActive(false);
            _button.enabled = true;
        }
    }

    void HitChest()
    {
        int currentCount = 0;
        currentCount++; 
    }



}
