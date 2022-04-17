using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoadSpawner : MonoBehaviour
{
    public GameObject[] roads;
    public GameObject parentObj;
    [SerializeField] private Vector3 nextRoadPos;
    [SerializeField] private Transform playerPos;
    [SerializeField] private float roadRate = 20f;
    private float _loadRateValue = 8f;
    private void Update()
    {
        if (playerPos.position.z >= _loadRateValue)
        {
            nextRoadPos = new Vector3(transform.position.x,transform.position.y, nextRoadPos.z + roadRate);
            GameObject tempRoad = Instantiate(roads[Random.Range(0,roads.Length)],nextRoadPos,Quaternion.identity);
            tempRoad.transform.parent = parentObj.transform;
            _loadRateValue += roadRate/2;
        }
    }
}
