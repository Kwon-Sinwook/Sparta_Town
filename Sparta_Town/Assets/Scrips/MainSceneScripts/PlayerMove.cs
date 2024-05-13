using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Movecontroller movecontroller;
    private Rigidbody2D rigidbody;
    public Camera camera;

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

    private void Update()
    {
        Vector2 dir = this.transform.position - camera.transform.position;
        Vector3 moveVector = new Vector3(dir.x * 20f * Time.deltaTime, dir.y * 20f * Time.deltaTime, 0.0f);
        camera.transform.Translate(moveVector);
    }

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
