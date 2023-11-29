using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerInputController controller;
    public Animator animator;
    // Start is called before the first frame update

    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
    }

    private void Start()
    {
        controller.OnMoveEvent += AnimState;
    }

    private void AnimState(Vector2 dir)
    {
        animator.SetBool("PlayerMove", dir.magnitude > 0);
    }


}
