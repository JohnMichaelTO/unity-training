using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    public Character character;
    public Button blue;
    public Button red;
    public Button green;
    public Text textCharacter;

    void Start()
    {
        blue.onClick.AddListener(setCharacterToBlue);
        red.onClick.AddListener(setCharacterToRed);
        green.onClick.AddListener(setCharacterToGreen);
    }

    private void setCharacterToGreen()
    {
        character.SetColor(Color.green);
        character.title = "Green";
    }

    private void setCharacterToRed()
    {
        character.SetColor(Color.red);
        character.title = "Red";
    }

    private void setCharacterToBlue()
    {
        character.SetColor(Color.blue);
        character.title = "Blue";
    }
}
