using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;

    [SerializeField] float deathSideX;

    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += Vector2.left.x * moveSpeed * Time.deltaTime;

        transform.position = newPos;

        if(transform.position.x <= deathSideX)
        {
            Destroy(gameObject);
        }
    }

}
