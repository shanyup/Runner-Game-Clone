using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameStart;
    [SerializeField] private GameObject player;
    private int _gold;
    [SerializeField]private int _firstTime = 0;

    public static GameManager instance;
    
    public int Gold
    {
        get { return _gold;}
        set { _gold = value; }
    }
    
    
    private void Awake()
    {
        instance = this;
        _firstTime = PlayerPrefs.GetInt("FirstTime");
        //The app will run once opened.
        if (_firstTime == 0)
        {
            PlayerPrefs.SetInt("FirstTime",1);
            SaveGame.instance.SavePlayerPrefs();
            _firstTime = PlayerPrefs.GetInt("FirstTime");
        }
        else
        { 
            //
        }
    }

    private void Start()
    {
        UIManager.instance.UpdateUIMarket();
    }

    public void GameState(bool gameState)
    {
        isGameStart = gameState;
        player.GetComponent<PlayerMovement>().enabled = gameState;
    }
    
    public void AddGold(int amount)
    {
        int tempGold = PlayerPrefs.GetInt("Gold");
        _gold = tempGold + amount;
        PlayerPrefs.SetInt("Gold",_gold);
    }

    public void Purchase(int amount)
    {
        int tempGold = PlayerPrefs.GetInt("Gold");
        _gold = tempGold - amount;
        PlayerPrefs.SetInt("Gold",_gold);
    }
}
