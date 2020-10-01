﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public static float bottomY = -10f;

    private Rigidbody rb;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            //destroy fuction removes things that are passed into it from the game
            SceneManager.LoadScene("EscapeMineField");
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StageClear"))
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene("EscapeMineField");
        }
        if (other.gameObject.CompareTag("Mines"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("EscapeMineField");
        }
    }

}