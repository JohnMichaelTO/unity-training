using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetPanel : MonoBehaviour
{
    public Character character;
    public Button reset;
    public Text textCharacter;

    void Start()
    {
        reset.onClick.AddListener(resetColor);
    }

    private void resetColor()
    {
        character.Reset();
        textCharacter.text = "White";
    }
}
