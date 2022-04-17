using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public static SaveGame instance;

    private void Awake()
    {
        instance = this;
    }

    public void SavePlayerPrefs()
    {
        #region SkinSave
        PlayerPrefs.SetInt("characterSkin0",0);
        PlayerPrefs.SetInt("characterSkin1",0);
        PlayerPrefs.SetInt("characterSkin2",0);
        PlayerPrefs.SetInt("characterSkin3",0);
        PlayerPrefs.SetInt("characterSkin4",0);
        PlayerPrefs.SetInt("characterSkin5",0);
        PlayerPrefs.SetInt("characterSkin6",0);
        PlayerPrefs.SetInt("characterSkin7",0);
        PlayerPrefs.SetInt("characterSkin8",0);

        #endregion

        #region PlayerGold
        
        PlayerPrefs.SetInt("Gold",0);

        #endregion

        #region Achievement

        //Will be add.

        #endregion
        PlayerPrefs.Save();
    }

    public void SaveBuyButton(int index)
    {
        string tempString = "characterSkin" + index;
        PlayerPrefs.SetInt(tempString,1);
        PlayerPrefs.Save();
    }
}
