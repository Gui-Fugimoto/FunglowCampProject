﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";
    public float moveSpeed = 1;
    public float dashDuration = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);

        if (Input.GetKeyUp("space"))
        {
            StartCoroutine(RollSpeed());
        }


        //  move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }


    IEnumerator RollSpeed()
    {

        moveSpeed = 0.3f;
        yield return new WaitForSeconds(dashDuration);
        moveSpeed = 0.1f;
    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }


    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
    }
    private void Turn(float input)
    {
        transform.Translate(Vector3.right * input * moveSpeed);
    }
}
