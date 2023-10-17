using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float pipeMoveSpeed = 5f;

    void Start() 
    {
        DestroyYourself();    
    }

    void Update() 
    {
        Move();    
    }

    void Move()
    {
        Vector2 newPos = transform.position;
        newPos.x += Vector2.left.x * pipeMoveSpeed * Time.deltaTime;

        transform.position = newPos;
    }

    void DestroyYourself()
    {
        Destroy(gameObject, 15f);
    }
    
}
