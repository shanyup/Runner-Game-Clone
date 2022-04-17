using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _obstaclePos;
    [SerializeField] private GameObject[] _obstacles;
    private void Start()
    {
        for (int i = 0; i < _obstaclePos.Length; i++)
        {
            GameObject tempObj = Instantiate(_obstacles[Random.Range(0,_obstacles.Length)].gameObject,_obstaclePos[i]);
        }
    }
}
