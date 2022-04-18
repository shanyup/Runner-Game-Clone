using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float _movementSpeed = 3f;
    private Animator _animator;
    private float speedModifier = 0.01f;
    private Touch _touch;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        if (GameManager.instance.isGameStart)
        {
            _animator.SetBool("isGameStart",true);
        }
    }

    private void Update()
    {
        Move();
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);
            if (_touch.phase == TouchPhase.Moved)
            {
                if (transform.position.x + _touch.deltaPosition.x*speedModifier > -3 && transform.position.x + _touch.deltaPosition.x*speedModifier < 3)
                {
                    transform.position = new Vector3(transform.position.x+_touch.deltaPosition.x*speedModifier,transform.position.y,transform.position.z);
                }
            }
        }
    }

    private void Move()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z + _movementSpeed*Time.deltaTime);
    }
}
