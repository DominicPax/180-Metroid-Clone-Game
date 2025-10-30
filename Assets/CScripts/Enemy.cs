using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 1;

    public Transform leftPoint;
    public Transform rightPoint;

    public float speed = 10;

    private Vector3 direction;
    private Vector3 startLeftPos;
    private Vector3 startRightPos;

    void Start()
    {
        direction = Vector3.left;
        startLeftPos = leftPoint.position;
        startRightPos = rightPoint.position;
    }



    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;

        //check if enemy has reached the left point
        if (direction == Vector3.left && transform.position.x <= startLeftPos.x)
        {
            direction = Vector3.right;
        }
        else if (transform.position.x >= startRightPos.x)
        {
            direction = Vector3.left;
        }
    }
}
