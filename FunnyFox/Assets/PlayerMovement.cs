using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public Animator Animator;

    public float RunSpeed = 40f;

    private float _horizontalMove = 0f;
    private bool _jump = false;
    private bool _crouch = false;
    private static readonly int Speed = Animator.StringToHash("Speed");
    private static readonly int IsJumping = Animator.StringToHash("IsJumping");
    private static readonly int IsCrouching = Animator.StringToHash("IsCrouching");

    // Update is called once per frame
    public void Update()
    {
        _horizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        Animator.SetFloat(Speed, Math.Abs(_horizontalMove));

        // when the key is pressed
        if (Input.GetButtonDown("Jump"))
        {
            _jump = true;
            Animator.SetBool(IsJumping, true);
        }

        // when the key is pressed
        if (Input.GetButtonDown("Crouch"))
        {
            _crouch = true;
        }
        // when the key is loosen
        else if (Input.GetButtonUp("Crouch"))
        {
            _crouch = false;
        }
    }

    public void OnLanding()
    {
        Animator.SetBool(IsJumping, false);
    }

    public void OnCrouching(bool isCrouching)
    {
        Animator.SetBool(IsCrouching, isCrouching);
    }

    private void FixedUpdate()
    {
        // Move our character
        Controller.Move(_horizontalMove * Time.fixedDeltaTime, _crouch, _jump);
        _jump = false;
    }
}
