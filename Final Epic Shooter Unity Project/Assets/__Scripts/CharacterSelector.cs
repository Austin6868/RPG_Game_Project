﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{

    public void SelectCharacter()
    {
        //the player's choice to instantiate between two characters"Hero1" and "Hero2"
        if(gameObject.CompareTag("Hero 1"))
        {
            PlayerPrefs.SetInt("Hero", 1);

            Debug.Log(PlayerPrefs.GetInt("Hero"));
        }
        else if(gameObject.CompareTag("Hero 2"))
        {
            PlayerPrefs.SetInt("Hero", 2);

            Debug.Log(PlayerPrefs.GetInt("Hero"));
        }
    }
}
