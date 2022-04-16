using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public SkinCreator[] CharacterStats;
    public static ShopManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void BuyCharacter(int index)
    {
        if (GameManager.instance.Gold >= CharacterStats[index].SkinSettings.CharacterPrice)
        {
            GameManager.instance.Purchase(CharacterStats[index].SkinSettings.CharacterPrice);
            CharacterSkinManager.instance.isSold[index] = true;
            UIManager.instance.UIBorderChange(index);
        }
        else
        {
            UIManager.instance.LogError(1);
        }
    }
}
