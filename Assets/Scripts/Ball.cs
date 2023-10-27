using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigid;

    [SerializeField] float jumpForce = 200;

    bool isClick => Input.GetMouseButtonDown(0);

    void Update() 
    {
        Jump(); 
    }

    void Jump()
    {
        if(isClick)
        {
            myRigid.velocity = Vector2.zero;
            myRigid.AddForce(Vector2.up * jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Pipe") || other.gameObject.CompareTag("Death"))
        {
            GameManager.Instance.GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Score"))
        {
            GameManager.Instance.IncreaseScore();
        }    
    }

}
