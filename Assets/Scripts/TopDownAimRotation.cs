using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    public SpriteRenderer PlayerRenderer;

    private TopDownCahracterControllers _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCahracterControllers>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        PlayerRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
