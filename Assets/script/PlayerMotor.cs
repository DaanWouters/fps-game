using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 PlayerVelocoty;
    public bool IsGrounded;
    public float speed = 7.5f;
    public float gravity = -9.8f;
    public float jumpheight = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = controller.isGrounded;
    }


    //receive the inputs for out inputmanager.cs and apply them to our character controller.
    public void Processmove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
       controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        PlayerVelocoty.y += gravity * Time.deltaTime;
        if (IsGrounded && PlayerVelocoty.y < 0)
            PlayerVelocoty.y = -2f;
        controller.Move(PlayerVelocoty * Time.deltaTime);
        Debug.Log(PlayerVelocoty.y);

    }

    public void Jump()
    {
        if (IsGrounded)
        {
            PlayerVelocoty.y = Mathf.Sqrt(jumpheight * -1.5f * gravity);

        }
    }


}
