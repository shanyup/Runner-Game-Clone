using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameManager.instance.GameState(false);
            UIManager.instance.LosePanel.SetActive(true);
        }
    }
}
