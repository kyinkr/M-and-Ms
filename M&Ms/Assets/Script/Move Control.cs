using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.LowLevel;

public class MoveControl: MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;

    private Vector3 movement;
    // Update is called once per frame
    void Update()
    {
        //좌우 이동
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position +  movement * moveSpeed * Time.fixedDeltaTime);
    }     
}
