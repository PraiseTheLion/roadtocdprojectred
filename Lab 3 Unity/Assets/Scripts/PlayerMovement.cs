﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 7f;
    public float moveOnY = 0f;
    public float moveOnZ = 0f;
    public float jumpOnY = 5f;
    public bool isFloor = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), moveOnY, moveOnZ);
        transform.position += movement * Time.deltaTime * movementSpeed;
    }

    void Jump() {
        if (Input.GetButtonDown("Jump") && isFloor == true) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpOnY), ForceMode2D.Impulse);
        }        
    }
}