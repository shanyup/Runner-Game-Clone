using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSkinManager : MonoBehaviour
{
    [SerializeField] private GameObject[] characters;

    public static CharacterSkinManager instance;

    private void Awake()
    {
        instance = this;
    }
    public void EquipSkin(int index)
    {
        foreach (var item in characters)
        {
            item.SetActive(false);
        }
        characters[index].SetActive(true);
    }
}
