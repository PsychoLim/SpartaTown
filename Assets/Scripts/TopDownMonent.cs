using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMonent : MonoBehaviour
{
    // Start is called before the first frame update
    private TopDownCahracterControllers _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCahracterControllers>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move;
        //_controller.OnMoveEvent += HandlePlayerMove;
    }

    private void FixedUpdate()
    {
        ApplyMovent(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovent(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }

    //public void HandlePlayerMove(Vector2 movement)
    //{
    //    Transform childTransform = transform.Find("PlayerMainSprite");
    //    Animator childanimator = childTransform.GetComponent<Animator>();

    //    if (movement.y > 0)
    //    {
    //        childanimator.SetBool("MoveUp", true);
    //        childanimator.SetBool("MoveDown", false);
    //    }
    //    else if (movement.y < 0)
    //    {
    //        childanimator.SetBool("MoveDown", true);
    //        childanimator.SetBool("MoveUp", false);
    //    }
    //    else
    //    {
    //        childanimator.SetBool("MoveDown", false);
    //        childanimator.SetBool("MoveUp", false);
    //    }

    //    if (movement.x > 0)
    //    {
    //        childanimator.SetBool("MoveRight", true);
    //        childanimator.SetBool("MoveLeft", false);
    //    }
    //    else if (movement.x < 0)
    //    {
    //        childanimator.SetBool("MoveRight", false);
    //        childanimator.SetBool("MoveLeft", true);
    //    }
    //    else
    //    {
    //        childanimator.SetBool("MoveRight", false);
    //        childanimator.SetBool("MoveLeft", false);
    //    }

    //}
}

