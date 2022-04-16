using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]private Transform _target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float dragSpeed;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position,_target.position + offset,dragSpeed * Time.deltaTime);
    }
}
