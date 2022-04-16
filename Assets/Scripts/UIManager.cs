using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button[] BuyButtons;
    public Button[] EquipButtons;
    public GameObject[] BorderList;
    public GameObject[] SoldBorderList;
    [SerializeField] private TextMeshProUGUI _errorText;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _high_scoreText;

    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (GameManager.instance.isGameStart)
        {
            //CurrentScore will change
        }
        else if (!GameManager.instance.isGameStart)
        {
            //Highscore will change
        }
    }

    public void UIBorderChange(int index)
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
