using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSkinManager : MonoBehaviour
{
    public bool[] isSold = new bool[9];
    [SerializeField] private GameObject[] skins;

    public static CharacterSkinManager instance;

    private void Awake()
    {
        instance = this;
    }
    
    public void EquipSkin(int index)
    {
        foreach (var item in skins)
        {
            item.SetActive(false);
        }
        skins[index].SetActive(true);
    }
}
