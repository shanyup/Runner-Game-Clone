using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{   
    public static ShopManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void BuyCharacter(int amount)
    {
        GameManager.instance.Purchase(amount);
        //UI change with unlock item.
    }
}
