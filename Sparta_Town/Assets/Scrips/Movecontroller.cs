using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecontroller : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;


    public void CallMoveEvent(Vector2 diretion)
    {
        OnMoveEvent?.Invoke(diretion);
    }







}
