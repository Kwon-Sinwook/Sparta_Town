using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Movecontroller movecontroller;
    private Rigidbody2D rigidbody;

    private Vector2 moveDirection = Vector2.zero;


    private void Awake()
    {
        movecontroller = GetComponent<Movecontroller>();
        rigidbody = GetComponent<Rigidbody2D>();
    }


    private void Start()
    {
        movecontroller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        moveDirection = direction;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ApplyMovement(moveDirection);   
    }

    private void ApplyMovement(Vector2 moveDirection)
    {
        moveDirection = moveDirection * 5;
        rigidbody.velocity = moveDirection;
    }
}
