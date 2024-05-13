using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private Movecontroller movecontroller;

    private void Awake()
    {
        movecontroller = GetComponent<Movecontroller>();
    }


    void Start()
    {
        movecontroller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateSprite(newAimDirection);
    }

    private void RotateSprite(Vector2 newAimDirection)
    {
        float rotZ = Mathf.Atan2(newAimDirection.y, newAimDirection.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
