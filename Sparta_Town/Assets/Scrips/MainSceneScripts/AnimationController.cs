using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected Movecontroller movecontroller;


    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        movecontroller = GetComponent<Movecontroller>();
    }
}
