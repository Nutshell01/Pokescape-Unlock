using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInputs;

    private Mouse mouse;

    private void Awake()
    {
        playerInputs = GetComponent<PlayerInput>();
        mouse = Mouse.current;
    }

    private void OnFire()
    {
        //Click
    }
}
