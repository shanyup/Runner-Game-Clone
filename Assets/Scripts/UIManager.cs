using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject WinPanel, LosePanel;
    
    public SkinCreator[] Skins;
    public Image[] CharacterSprite;
    public TextMeshProUGUI[] CharacterName;
    public TextMeshProUGUI[] CharacterPrice;
    public Button[] BuyButtons;
    public Button[] EquipButtons;
    public GameObject[] BorderList;
    public GameObject[] SoldBorderList;
    
    [SerializeField]private TextMeshProUGUI _scoreText;
    [SerializeField]private TextMeshProUGUI _high_scoreText;
    [SerializeField] private TextMeshProUGUI _errorText;
    
    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }
    

    public void ScoreUpdate(int scoreValue)
    {
        _scoreText.text = scoreValue.ToString();
    }
    
    //Highscore controll be add.
    
    private void UpdateSkins()
    {
        for (int i = 0; i < Skins.Length; i++)
        {
            CharacterSprite[i].sprite = Skins[i].SkinSettings.CharacterSprite;
            CharacterName[i].text = Skins[i].SkinSettings.CharacterName;
            CharacterPrice[i].text = Skins[i].SkinSettings.CharacterPrice.ToString();
        }
    }
    public void UpdateUIMarket()
    {
        //UpdateSkins();
        for (int i = 0; i < BuyButtons.Length; i++)
        {
            string tempIndex = "characterSkin" + i;
            Debug.Log(tempIndex);
            int temp = PlayerPrefs.GetInt(tempIndex);
            if (temp == 1)
            {
                BuyButtons[i].interactable = false;
            }
        }
    }
    public void UIButtonChange(int index)
    {
        BorderList[index].SetActive(false);
        SoldBorderList[index].SetActive(true);
        BuyButtons[index].interactable = false;
        BuyButtons[index].GetComponentInChildren<TextMeshProUGUI>().text = "Purchased";
    }

    public void LogError(int errorIndex)
    {
        switch (errorIndex)
        {
            //Error code 1: If we don't have enough gold when buying a character.
            case 1:
                _errorText.text = "You don't have enough gold.";
                break;
        }
    }
}
