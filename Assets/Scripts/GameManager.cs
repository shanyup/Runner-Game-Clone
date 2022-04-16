using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameStart;
    [SerializeField] private GameObject player;
    private int _gold;


    public static GameManager instance;
    
    public int Gold
    {
        get { return _gold;}
        set { _gold = value; }
    }
    
    
    private void Awake()
    {
        instance = this;
    }
    public void GameState(bool gameState)
    {
        isGameStart = gameState;
        player.GetComponent<PlayerMovement>().enabled = gameState;
    }
    
    public void AddGold(int amount)
    {
        _gold += amount;
    }

    public void Purchase(int amount)
    {
        _gold -= amount;
    }
}
