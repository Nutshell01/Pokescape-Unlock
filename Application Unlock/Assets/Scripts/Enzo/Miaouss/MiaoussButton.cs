using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiaoussButton : MonoBehaviour
{
    private enum Position
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5,
        Sixth = 6,
        Seventh = 7,
        Eighth = 8
    };
    private Position ButtonPosition;
    [SerializeField] Position _goodPos;
    private int _count;
    public bool _isGood;


    [SerializeField] Sprite[] sprites;
    [SerializeField] Image _spriteRenderer;
    [SerializeField] int _maxCount;


    void Start()
    {
        _count = 1;
    }

    void Update()
    {
        CheckWhichPos();
        _spriteRenderer.sprite = sprites[_count - 1];

        if (_goodPos == ButtonPosition)
        {
            _isGood = true;
        }
        else
        {
            _isGood = false;
        }
    }

    public void ClickCount()
    {
        _count++;
        if (_count > _maxCount)
        {
            _count = 1;
        }
    }
    private void CheckWhichPos()
    {
       int ToInt = (int)ButtonPosition;
       ToInt = _count;
       ButtonPosition = (Position)ToInt;
    }
}
