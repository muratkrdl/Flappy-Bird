using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigid;
    [SerializeField] float jumpForce = 5f;

    bool isClick => Input.GetMouseButtonDown(0);

    GameManager gameManager;

    void Awake() 
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update() 
    {
        Jump();    
    }

    void Jump()
    {
        if(isClick)
        {
            myRigid.velocity = new Vector2(0, 0);
            myRigid.AddForce(Vector2.up * jumpForce);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Pipe"))
        {
            Time.timeScale = 0;
            Debug.Log("Game Over !");
        }
        else if(other.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            Debug.Log("Game Over !");
        }
        else if(other.gameObject.CompareTag("Score"))
        {
            gameManager.IncreaseScore();
        }
    }

}
