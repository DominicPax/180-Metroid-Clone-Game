using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HardEnemy : MonoBehaviour
{

    public int health = 10;
    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    private void Update()
    {
        PlayerDetection();
        MoveLeft();
        MoveRight();
    }


    private void PlayerDetection()
    {


        RaycastHit hit;

        Vector3 leftOrigin, rightOrigin;

        //Calculate where to draw the raycast from on the left side
        leftOrigin = transform.position + new Vector3(0, 0, 0);
        rightOrigin = transform.position + new Vector3(0, 0, 0);

        if (Physics.Raycast(leftOrigin, Vector3.left, out hit, 100f))
        {
            if (hit.transform.GetComponent<PlayerController>())
            {
                isMovingLeft = true;
                print("PlAYER IS ON LEFT");
            }
            else
            {
                isMovingLeft = false;
                print("PlAYER IS NOT LEFT");
            }
        }

        else
        {
            isMovingLeft = false;
        }

        if (Physics.Raycast(rightOrigin, Vector3.right, out hit, 100f))
        {
            if (hit.transform.GetComponent<PlayerController>())
            {
                isMovingRight = true;
                print("PLAYER IS ON RIGHT");

            }
            else
            {
                isMovingRight = false;
                print("PlAYER IS NOT RIGHT");

            }
        }
        else
        {
            isMovingRight = false;
        }
    }


    private void MoveLeft()
    {
        if (isMovingLeft == true)
        transform.position += Vector3.left * 2f * Time.deltaTime;
        print("MOVING LEFT");
    }

    private void MoveRight()
    {
        if (isMovingRight == true)
            transform.position += Vector3.right * 2f * Time.deltaTime;
        print("MOVING RIGHT");

    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.GetComponent<Bullet>())
            {
                Bullet bullet = other.gameObject.GetComponent<Bullet>();

                health -= bullet.bulletDamage;

                if (health <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

}
