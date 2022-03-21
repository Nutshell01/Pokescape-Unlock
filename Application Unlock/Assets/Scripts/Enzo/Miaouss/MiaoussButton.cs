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
        Fourth = 4
    };
    private Position ButtonPosition;
    [SerializeField] Position _goodPos;
    private int _count;
    public bool _isGood;


    [SerializeField] Sprite[] sprites;
    [SerializeField] Image _spriteRenderer;


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
        if (_count > 4)
        {
            _count = 1;
        }
    }
    private void CheckWhichPos()
    {
        if (_count == 1)
        {
            ButtonPosition = Position.First;
            
        }

        if (_count == 2)
        {
            ButtonPosition = Position.Second;
        }

        if (_count == 3)
        {
            ButtonPosition = Position.Third;
        }

        if (_count == 4)
        {
            ButtonPosition = Position.Fourth;
        }
    }
}
